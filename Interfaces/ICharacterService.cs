using Practice.Dtos.Character;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Interfaces
{
    /// <summary>
    /// 角色服務介面
    /// </summary>
    public interface ICharacterService
    {
        /// <summary>
        /// 取得所有角色
        /// </summary>
        /// <returns></returns>
        Task<ServiceResponse<List<GetCharacterDto>>> GetAll();

        /// <summary>
        /// 依 ID 取得角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ServiceResponse<GetCharacterDto>> GetById(int id);

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="newCharacter"></param>
        /// <returns></returns>
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    }
}
