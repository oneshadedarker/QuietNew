using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiet.MosterManual
{
    public class BaseMonster
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        public BaseMonster(int currentHealth, int maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }
    }
}
