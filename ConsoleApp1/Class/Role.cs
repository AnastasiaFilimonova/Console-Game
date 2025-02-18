using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Role
    {
        public string Name { get; set; }
        /// <summary>
        /// Максимальное здоровье
        /// </summary>
        public uint Health { get; set; }
        /// <summary>
        /// Текущее здоровье
        /// </summary>
        public uint CurrentHealth { get; set; }
        /// <summary>
        /// Сила
        /// </summary>
        public int Strong { get; set; }
        /// <summary>
        /// Защита
        /// </summary>
        public int Protect { get; set; }
        /// <summary>
        /// Уровень
        /// </summary>
        public uint Level { get; set; }
        /// <summary>
        /// Минимальная атака
        /// </summary>
        public int MinAttack { get; set; }
        /// <summary>
        /// Максимальная атака
        /// </summary>
        public int MaxAttack { get; set; }
        public Role(string name, uint health, uint currentHealth, int strong, int protect, uint level, int minAttack, int maxAttack)
        {
            Name = name;
            Health = health;
            CurrentHealth = currentHealth;
            Strong = strong;
            Protect = protect;
            Level = level;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
        }
    }    
}





