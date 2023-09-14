using Library.Business;
using Library.Model;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentController : ControllerBase
    {
        private readonly ILogger<RentController> _logger;
        private IRentBusiness _rentBusiness;

        public RentController(ILogger<RentController> logger, IRentBusiness rentBusiness)
        {
            _logger = logger;
            _rentBusiness = rentBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_rentBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var rent = _rentBusiness.FindById(id);
            if (rent == null) return NotFound();
            return Ok(rent);
        }

        [HttpPost]
        public IActionResult Post([FromBody] RentVO rent)
        {
            if (rent == null) return BadRequest();
            return Ok(_rentBusiness.Create(rent));
        }

        [HttpPut]
        public IActionResult Put([FromBody] RentVO rent)
        {
            if (rent == null) return BadRequest();
            return Ok(_rentBusiness.Update(rent));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _rentBusiness.Delete(id);
            return NoContent();
        }
    }
}
