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
        private static List<Character> characters = new List<Character>() 
        { 
            new Character(),
            new Character{ Name="Ash"}
        };

        [HttpGet("GetAll")]
        // [Route("GetAll")] 2 種路由寫法都可以
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet] // Swagger 需要加
        public ActionResult<Character> GetSingle()
        {
            return Ok(characters[0]);
        }

    }
}
