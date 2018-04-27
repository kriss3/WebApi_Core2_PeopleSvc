using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.API.Models
{
    public class PersonDto
    {
        public int Id { get; set; } //Identity
        public string FirstName { get; set; } //nvarchar(50)
        public string LastName { get; set; } //nvarchar(50)
        public int Age { get; set; } //not null
        public string Address { get; set; } //nvarchar 50 null
    }
}
