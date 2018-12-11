using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend1.Models;

namespace Backend1.Controllers
{
    public class PersonController : Controller
    {

        private PersonContext context;

        public PersonController(PersonContext context){
           this.context = context;
        }

        // Get person with id.
        [Route("getPersons")]
        [HttpGet]
        public ActionResult <IEnumerable<Person>> GetPerson()
        {
            return context.Persons.ToList();
        }

        // Add new person to db.
        [Route("insertPerson")]
        [HttpPost]
        public async Task<IActionResult> AddPerson([FromForm] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await context.Persons.AddAsync(person);
            await context.SaveChangesAsync();
            return Ok(person);
        }
    }
}
