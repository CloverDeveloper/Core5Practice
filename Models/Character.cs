using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Character
    {
        public int Id { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; } = "Frodo";

        /// <summary>
        /// 命中
        /// </summary>
        public int HitPoints { get; set; } = 100;

        /// <summary>
        /// 力量
        /// </summary>
        public int Strength { get; set; } = 10;

        /// <summary>
        /// 防禦
        /// </summary>
        public int Defense { get; set; } = 10;

        /// <summary>
        /// 智力
        /// </summary>
        public int Intelligence { get; set; } = 10;

        /// <summary>
        /// 職業
        /// </summary>
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}
