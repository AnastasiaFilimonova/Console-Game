using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Hero: Role
    {
        /// <summary>
        /// Опыт
        /// </summary>
        public uint Exp { get; set; }

        public Hero (string name, uint health, uint currentHealth, int strong, int protect, uint level, uint exp, int minAttack, int maxAttack) : base (name, health, currentHealth, strong, protect, level, minAttack, maxAttack)
        {
            Exp = exp;
        }
    }
}

