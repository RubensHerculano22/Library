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
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private IUserBusiness _userBusiness;

        public UserController(ILogger<UserController> logger, IUserBusiness userBusiness)
        {
            _logger = logger;
            _userBusiness = userBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_userBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var user = _userBusiness.FindById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserVO user)
        {
            if (user == null) return BadRequest();
            return Ok(_userBusiness.Create(user));
        }

        [HttpPut]
        public IActionResult Put([FromBody] UserVO user)
        {
            if (user == null) return BadRequest();
            return Ok(_userBusiness.Update(user));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _userBusiness.Delete(id);
            return NoContent();
        }
    }
}
