using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDirectoryApp.Web.DTOs;
using UserDirectoryApp.Core.Services;

namespace UserDirectoryApp.Web.Filters
{
    public class UsertNotFoundFilter : ActionFilterAttribute
    {
        private readonly IUserService _userService;

        public UsertNotFoundFilter(IUserService userService)
        {
            _userService = userService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Guid id = (Guid)context.ActionArguments.Values.FirstOrDefault();
            var user = await _userService.GetByIdAsync(id);

            if (user != null)
            {
                await next();
            }

            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Errors.Add($"Id'si {id} olan üye bulunamadı.");
                context.Result = new RedirectToActionResult("Error", "Home", errorDto);
            }
        }
    }
}
