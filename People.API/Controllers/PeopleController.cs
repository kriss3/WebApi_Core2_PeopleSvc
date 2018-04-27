using Microsoft.AspNetCore.Mvc;
using People.API.Models;
using People.API.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.API.Controllers
{
    [Route("/api/[controller]")]
    public class PeopleController : Controller
    {
        [HttpGet()]
        public IActionResult GetPeople()
        {
            return Ok(PeopleStore.CurrentStore.People);
        }

        [HttpGet("{id}", Name ="GetPerson")]
        public IActionResult GetPerson(int id)
        {
            //find person;
            var foundPerson = PeopleStore.CurrentStore.People.FirstOrDefault(p => p.Id == id);
            if (foundPerson == null)
                return NotFound();
            return Ok(foundPerson);
        }

        [HttpPost()]
        public IActionResult CreatePerson([FromBody] PersonForCreationDto newPerson)
        {
            if (newPerson == null)
            {
                BadRequest();
            }

            if (newPerson.FirstName.Equals(newPerson.LastName))
                ModelState.AddModelError("LastName", "First Name and Last Name should be different.");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var maxPersonId = PeopleStore.CurrentStore.People.Max(m => m.Id);

            var finalPerson = new PersonDto()
            {
                Id = ++maxPersonId,
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                Age = newPerson.Age,
                Address = newPerson.Address //add condition; Address can be empty/null;
            };

            PeopleStore.CurrentStore.People.Add(finalPerson);
            return CreatedAtRoute("GetPerson", new { id = finalPerson.Id}, finalPerson);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePointOfIntrest(int id, [FromBody] PersonForUpdateDto updatedPerson)
        {
            if (updatedPerson == null)
                return BadRequest();

            if (updatedPerson.FirstName.Equals(updatedPerson.LastName))
                ModelState.AddModelError("LastName", "First Name and Last Name should be different.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var foundPerson = PeopleStore.CurrentStore.People.FirstOrDefault(p => p.Id == id);
            if (foundPerson == null)
                NotFound();

            foundPerson.FirstName = updatedPerson.FirstName;
            foundPerson.LastName = updatedPerson.LastName;
            foundPerson.Age = updatedPerson.Age;
            foundPerson.Address = updatedPerson.Address;

            return NoContent(); //204 => can also return 200OK and pass updated resource;
        }
    }
}
