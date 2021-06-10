using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDirectoryApp.Core.Repositories;

namespace UserDirectoryApp.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        void Commit();
        Task CommitAsync();
    }
}
