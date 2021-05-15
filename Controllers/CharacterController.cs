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
            new Character{ Id=1, Name="Ash"}
        };

        [HttpGet("GetAll")]
        // [Route("GetAll")] 2 種路由寫法都可以
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        // Swagger 需要加
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);

            return Ok(characters);
        }

    }
}
