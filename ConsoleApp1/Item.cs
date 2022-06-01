using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    internal abstract class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public Item(string name, string type, string description, int quantity)
        {
            Name = name;
            Type = type;
            Description = description;
            Quantity = quantity;
        }
    }
}
