using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Game
    {
        /// <summary>
        /// Персонаж
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Уровни
        /// </summary>
        public List<Level> Levels { get; set; }
        /// <summary>
        /// Текущий уровень
        /// </summary>
        public Level? CurrentLevel { get; set; }
        public Game (User user, List<Level> levels)
        {
            User = user;
            Levels = levels;
            CurrentLevel = null; 
        }
    }
}
