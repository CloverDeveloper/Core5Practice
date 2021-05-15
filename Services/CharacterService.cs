using Practice.Interfaces;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Services
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character{ Id=1, Name="Ash"}
        };

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="newCharacter"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);

            ServiceResponse<List<Character>> res = new ServiceResponse<List<Character>>();
            res.Data = characters;

            return res;
        }

        /// <summary>
        /// 取得所有角色
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResponse<List<Character>>> GetAll()
        {
            ServiceResponse<List<Character>> res = new ServiceResponse<List<Character>>();
            res.Data = characters;

            return res;
        }

        /// <summary>
        /// 依 ID 取得角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<Character>> GetById(int id)
        {
            ServiceResponse<Character> res = new ServiceResponse<Character>();

            res.Data = characters.FirstOrDefault(c => c.Id == id);

            return res;
        }
    }
}
