using People.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.API.Store
{
    public class PeopleStore
    {
        public static PeopleStore CurrentStore { get; } = new PeopleStore();
        public List<PersonDto> People { get; set; }

        public PeopleStore()
        {
            People = new List<PersonDto>()
            {
                new PersonDto{ Id=0, FirstName="Albert", LastName="Einstein", Age=76, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=1, FirstName="Richard", LastName="Feynman", Age=70, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=2, FirstName="Mari", LastName=" Curie", Age=67, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=3, FirstName="Stephen", LastName="Hawking", Age=76, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=4, FirstName="Carl", LastName="Sagan", Age=62, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=5, FirstName="Robert", LastName="Oppenheimer", Age=63, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=6, FirstName="Nikola", LastName="Tesla", Age=79, Address="123 Main Street, NY, V5Y012, USA" },
                new PersonDto{ Id=7, FirstName="Stefan", LastName="Banach", Age=53, Address="123 Main Street, BC, V5Y012, Poland" },
                new PersonDto{ Id=8, FirstName="Marian ", LastName="Rejewski", Age=75, Address="123 Main Street, BC, V5Y012, Poland" },
                new PersonDto{ Id=9, FirstName="Stanislaw", LastName="Ulm", Age=75, Address="123 Main Street, BC, V5Y012, New Mexico" }
            };
        }
    }
}
