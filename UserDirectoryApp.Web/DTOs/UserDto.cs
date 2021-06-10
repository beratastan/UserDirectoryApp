using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserDirectoryApp.Web.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
    }
}
