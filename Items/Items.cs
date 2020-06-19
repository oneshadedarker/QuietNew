using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiet.Items
{
    public class Items
    {        
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; } 
        
        public Items(int id, string name, string namePlural)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}
