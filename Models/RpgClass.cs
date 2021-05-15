using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Practice.Models
{
    // 將列舉值與字串相互轉換讓 Swagger 可以顯示名稱
    [JsonConverter(typeof(JsonStringEnumConverter))] 
    public enum RpgClass
    {
        /// <summary>
        /// 騎士
        /// </summary>
        Knight,
        /// <summary>
        /// 法師
        /// </summary>
        Mage,
        /// <summary>
        /// 牧師
        /// </summary>
        Cleric
    }
}
