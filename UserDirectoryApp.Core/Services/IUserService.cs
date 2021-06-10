using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDirectoryApp.Core.Models;

namespace UserDirectoryApp.Core.Services
{
    public interface IUserService : IService<User>
    {
        Task<IEnumerable<User>> SortByNameAndSurname();
    }
}
