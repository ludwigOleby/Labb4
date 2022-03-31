using Labb4.Services;
using Labb4.Models;
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
    public class InterestController : ControllerBase
    {
        private IInterestRepository<Interests> _interestRepo;

        public InterestController(IInterestRepository<Interests> intRepo)
        {
            _interestRepo = intRepo;
        }

        [HttpGet("{id}")]
        [Route("{id}/interest")]
        public async Task<ActionResult<Interests>> GetInterest(int id)
        {
            try
            {
                var result = await _interestRepo.GetInterest(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrive singel interest from database");
            }
        }
        [HttpPut("{id}")]
        [Route("{id}/update")]
        public async Task<ActionResult<Interests>> updateInterest(int id, Interests NewUpdate)
        {
            try
            {
                if (id != NewUpdate.PersonID)
                {
                    return BadRequest("Order id does not match....");
                }
                var ProdutctToUpdate = await _interestRepo.GetInterest(id);
                if (ProdutctToUpdate == null)
                {
                    return NotFound($"Order with {id} not found....");
                }
                return await _interestRepo.updateInterest(NewUpdate);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to update to database");
            }
        }


    }
}
