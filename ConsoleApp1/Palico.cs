using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    internal class Palico
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Gathering { get; set; }
        public int Exploring { get; set; }

        public Palico(string name, string type, int health, int attack, int gathering, int exploring)
        {
            Name = name;
            Type = type;
            Health = health;
            Attack = attack;
            Gathering = gathering;
            Exploring = exploring;
        }
       
    }
}
