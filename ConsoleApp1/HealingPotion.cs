using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    internal class HealingPotion : Potion // <--- Arvet fra Potion og Potion har alle attributes fra Item
    {
        public string PotionType;

        public HealingPotion(string name, string type, string description, int quantity, bool activeBuff, string potionType) 
            :base (name, type, description, 10, true)
        {
            PotionType = potionType;
        }
    }
}
