using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    internal class Potion : Item
    {
        
        public bool ActiveBuff;

        public Potion(string name, string type, string description, int quantity,bool activeBuff) 
            :base(name, type, description,quantity)
        {
            ActiveBuff = activeBuff;
        }

        //let name = "hei"
        //    function hallo(name)
    }
}
