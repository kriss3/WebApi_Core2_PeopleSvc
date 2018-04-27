using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace People.API.Models
{
    public class PersonForUpdateDto
    {
        [Required(ErrorMessage = "You should provide First Name.")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You should provide Last Name.")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "You should provide value for Age.")]
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
