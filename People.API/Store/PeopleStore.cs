using People.API.Models;
using System.Collections.Generic;

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
                new PersonDto{ Id=2, FirstName="Marie", LastName="Curie", Age=67, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=3, FirstName="Stephen", LastName="Hawking", Age=76, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=4, FirstName="Carl", LastName="Sagan", Age=62, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=5, FirstName="Robert", LastName="Oppenheimer", Age=63, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=6, FirstName="Nikola", LastName="Tesla", Age=79, Address="123 Main Street, NY, V5Y012, USA" },
                new PersonDto{ Id=7, FirstName="Stefan", LastName="Banach", Age=53, Address="123 Main Street, BC, V5Y012, Poland" },
                new PersonDto{ Id=8, FirstName="Marian ", LastName="Rejewski", Age=75, Address="123 Main Street, BC, V5Y012, Poland" },
                new PersonDto{ Id=9, FirstName="Stanislaw", LastName="Ulam", Age=75, Address="123 Main Street, BC, V5Y012, New Mexico" },
                new PersonDto{ Id=10, FirstName="Ariel", LastName="Rubinstein", Age=67, Address="Jerusalem, Israel" },
                new PersonDto{ Id=11, FirstName="Myrna", LastName="Wooders", Age=70, Address="Nashville, Tennessi 37235" },
                new PersonDto{ Id=12, FirstName="Monika", LastName="Henzinger", Age=52, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=13, FirstName="William", LastName="Hamilton", Age=64, Address="Cairo, Egipt" },
                new PersonDto{ Id=14, FirstName="Derek", LastName="Abbott", Age=58, Address="South Kensington, London" },
                new PersonDto{ Id=15, FirstName="Susanne", LastName="Albers", Age=52, Address="123 Main Street, BC, V5Y012, Canada" },
                new PersonDto{ Id=16, FirstName="Cristina", LastName="Bicchieri", Age=68, Address="Milan, Italy" },
                new PersonDto{ Id=17, FirstName="Robert", LastName="Aumann", Age=87, Address="Frankfurt am Main, Germany" },
                new PersonDto{ Id=18, FirstName="Steven", LastName="Brams", Age=77, Address="1Concord, New Hampshire" },
                new PersonDto{ Id=19, FirstName="Anna", LastName="Karlin", Age=58, Address="Washington, Seattle" },
                new PersonDto{ Id=20, FirstName="Olga", LastName="Bondareva", Age=54, Address="Leningrad, USSR" }
            };
        }
    }
}
