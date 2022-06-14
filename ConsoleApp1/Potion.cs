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

        protected Potion(string name, string type, string description, int quantity,bool activeBuff) 
            :base(name, type, description,quantity) // <-- Arvet fra Item
        {
            ActiveBuff = activeBuff;
        }

        //let name = "hei"
        //    function hallo(name)

        public static void Use()
        {
            Console.WriteLine("Use metoden i Potion, arvet fra Item");
        }
    }
}
