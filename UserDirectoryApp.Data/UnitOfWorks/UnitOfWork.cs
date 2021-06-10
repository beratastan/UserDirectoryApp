using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDirectoryApp.Core.Repositories;
using UserDirectoryApp.Core.UnitOfWorks;
using UserDirectoryApp.Data.Repositories;

namespace UserDirectoryApp.Data.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private UserRepository _userRepository;

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_appDbContext);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
