using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDirectoryApp.Core.Models;
using UserDirectoryApp.Core.Repositories;
using UserDirectoryApp.Core.Services;
using UserDirectoryApp.Core.UnitOfWorks;

namespace UserDirectoryApp.Service.Services
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IRepository<User> repository) : base(unitOfWork, repository)
        {

        }

        public async Task<IEnumerable<User>> SortByNameAndSurname()
        {
            return await _unitOfWork.Users.SortByNameAndSurname();
        }

    }
}
