using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UserDirectoryApp.Core.Models;
using UserDirectoryApp.Core.Services;
using UserDirectoryApp.Web.DTOs;
using UserDirectoryApp.Web.Filters;

namespace UserDirectoryApp.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<UserDto>>(users));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserDto userDto)
        {
            await _userService.AddAsync(_mapper.Map<User>(userDto));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(Guid id)
        {
            var user = await _userService.GetByIdAsync(id);
            return View(_mapper.Map<UserDto>(user));
        }

        [HttpPost]
        public IActionResult Update(UserDto userDto)
        {
            _userService.Update(_mapper.Map<User>(userDto));
            return RedirectToAction("Index");
        }

        [ServiceFilter(typeof(UsertNotFoundFilter))]
        public IActionResult Remove(Guid id)
        {
            var user = _userService.GetByIdAsync(id).Result;
            _userService.Remove(user);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Sort()
        {
            var users = await _userService.SortByNameAndSurname();
            return View("Index",_mapper.Map<IEnumerable<UserDto>>(users));
        }
    }
}
