using AutoMapper;
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

        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="newCharacter"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            Character character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) + 1;

            characters.Add(character);

            ServiceResponse<List<GetCharacterDto>> res = new ServiceResponse<List<GetCharacterDto>>();
            res.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();

            return res;
        }

        /// <summary>
        /// 取得所有角色
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAll()
        {
            ServiceResponse<List<GetCharacterDto>> res = new ServiceResponse<List<GetCharacterDto>>();
            res.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();

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

            res.Data = _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.Id == id));

            return res;
        }
    }
}
