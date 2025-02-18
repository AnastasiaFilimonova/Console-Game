using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Reward
    {
        /// <summary>
        /// Опыт
        /// </summary>
        public int Exp { get; set; }
        /// <summary>
        /// Максимальное здоровье
        /// </summary>
        public uint Health { get; set; }
        /// <summary>
        /// Сила
        /// </summary>
        public int Strong { get; set; }
        /// <summary>
        /// Защита
        /// </summary>
        public int Protect { get; set; }
        public Reward (int exp, uint health, int strong, int protect)
        {
            Exp = exp;
            Health = health;
            Strong = strong;
            Protect = protect;
        }
    }
}
