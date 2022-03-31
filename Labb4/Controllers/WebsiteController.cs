using Labb4.Models;
using Labb4.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteController : ControllerBase
    {
        private IWebsiteRepository<Websites> _webRepo;

        public WebsiteController(IWebsiteRepository<Websites> webRepo)
        {
            _webRepo = webRepo;
        }


        [HttpGet("{id:int}")]
        [Route("{id}/websites")]
        public async Task<ActionResult<Websites>> GetWebsite(int id)
        {
            var result = await _webRepo.GetWebsite(id);
            try
            {
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get data from database");
            }
        }

        [HttpPost]
        [Route("{id}/updateweb")]
        [HttpPost]
        public async Task<ActionResult<Websites>> Add(Websites newEntity)
        {
            try
            {
                if (newEntity == null)
                {
                    return BadRequest();
                }
                var createdEntity = await _webRepo.AddLinks(newEntity);
                return CreatedAtAction(nameof(GetWebsite), new { id = createdEntity.WebpageID }, createdEntity);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get data from database ");

            }
        }


    }
}
