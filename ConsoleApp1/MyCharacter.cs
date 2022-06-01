using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    internal class MyCharacter
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<Palico> PalicoList { get; set; }
        public List<Item> Inventory { get; set; }


        public MyCharacter (string name, string gender)
        {
            Name = name;
            Gender = gender;
        }
        
    }

}
