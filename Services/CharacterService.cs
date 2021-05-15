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
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);

            return characters;
        }

        /// <summary>
        /// 取得所有角色
        /// </summary>
        /// <returns></returns>
        public List<Character> GetAll()
        {
            return characters;
        }

        /// <summary>
        /// 依 ID 取得角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Character GetById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}
