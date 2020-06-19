using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiet.Items
{
    public class Weapons : Items
    {        
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapons(int id, string name, string namePlural, int minDamage, int maxDamage) : base(id, name, namePlural)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }    
}
