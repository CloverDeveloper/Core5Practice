using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        [HttpGet] // Swagger 需要加
        public ActionResult<Character> Get()
        {
            return Ok(knight);
        }
    }
}
