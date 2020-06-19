using Quiet.MosterManual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiet
{
    public class PlayerChar : BaseMonster
    {
        // need to declare and display health, money, exp, level and other resources 
        // available to the player.        
        public int Gold { get; set; }
        public int ExpPoints { get; set; }
        public int CurrentLevel { get; set; }
        public int CurrentEssence { get; set; }
        public int MaxEssence { get; set; }
        
        public PlayerChar(int currentHealth, int maxHealth, int gold, int exp, int level) : base(currentHealth, maxHealth)
        {
            Gold = gold;
            ExpPoints = exp;
            CurrentLevel = level;
        }
    }
}
