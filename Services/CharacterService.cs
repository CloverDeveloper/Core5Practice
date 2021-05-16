using Practice.Dtos.Character;
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
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            characters.Add(newCharacter);

            ServiceResponse<List<GetCharacterDto>> res = new ServiceResponse<List<GetCharacterDto>>();
            res.Data = characters;

            return res;
        }

        /// <summary>
        /// 取得所有角色
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAll()
        {
            ServiceResponse<List<GetCharacterDto>> res = new ServiceResponse<List<GetCharacterDto>>();
            res.Data = characters;

            return res;
        }

        /// <summary>
        /// 依 ID 取得角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<GetCharacterDto>> GetById(int id)
        {
            ServiceResponse<GetCharacterDto> res = new ServiceResponse<GetCharacterDto>();

            res.Data = characters.FirstOrDefault(c => c.Id == id);

            return res;
        }
    }
}
