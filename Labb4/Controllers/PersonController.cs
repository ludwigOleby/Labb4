using Labb4.Models;
using Labb4.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Labb4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonRepository<Person>  _PersonRepo;

        public PersonController(IPersonRepository<Person> personRepo)
        {
            _PersonRepo = personRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersons()
        {
            return Ok(await _PersonRepo.GetPersons());
        }

        [HttpGet]
        [Route("{id}/interests")]
        public async Task<ActionResult<Person>> GetPersonsInterests(int id)
        {
            try
            {
                var result = await _PersonRepo.GetPersonsInterests(id);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"Person with id {id} not found");
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get persons interests");
            }
        }

        [HttpGet]
        [Route("{id}/links")]
        public async Task<ActionResult<Person>> GetLinks(int id)
        {
            try
            {
                var result = await _PersonRepo.GetLinks(id);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"Person with id {id} not found");
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get persons links!");
            }
        }
    }
}
