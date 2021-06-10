using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDirectoryApp.Core.Models;

namespace UserDirectoryApp.Data.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        private readonly int[] _ids;
        public UserSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<User> builder)
        {


            var testUsers = new Faker<User>()
            .CustomInstantiator(f => new User())
            .RuleFor(u => u.Id, f => f.Random.Uuid())
            .RuleFor(u => u.Name, (f, u) => f.Name.FirstName())
            .RuleFor(u => u.Surname, (f, u) => f.Name.LastName())
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
            .RuleFor(u => u.BirthDate, (f, u) => f.Date.Past())
            .RuleFor(u => u.Location, (f, u) => f.Address.City());
            var user = testUsers.Generate(10);
            builder.HasData(user);


        }
    }
}
