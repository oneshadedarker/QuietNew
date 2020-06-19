using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiet.MosterManual
{
    public class Monster : BaseMonster
    {
        public int ID { get; set; }
        public string Name { get; set; }        
        public int MaxDamage { get; set; }
        public int ExpPoints { get; set; }
        public int Gold { get; set; }

        public Monster(int id, string name, int maxDamage, int expPoints, int gold, int currentHealth, int maxHealth) : base(currentHealth, maxHealth)
        {
            ID = id;
            Name = name;
            MaxDamage = maxDamage;
            ExpPoints = expPoints;
            Gold = gold;
        }
    }   
}
