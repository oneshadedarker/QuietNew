using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiet.Stories
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Exp { get; set; }
        public int Gold {get;set;}

        public Quest(int id, string name, string description, int exp, int gold)
        {
            ID = id;
            Name = name;
            Description = description;
            Exp = exp;
            Gold = gold;
        }
    }
}
