using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDirectoryApp.Core.Models;
using UserDirectoryApp.Core.Repositories;

namespace UserDirectoryApp.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public async Task<IEnumerable<User>> SortByNameAndSurname()
        {
            return await _appDbContext.Users.OrderBy(x => x.Name).ThenByDescending(x=>x.Surname).ToListAsync();
        }
    }
}
