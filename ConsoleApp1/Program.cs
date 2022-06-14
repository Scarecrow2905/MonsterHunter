using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var player = new MyCharacter("Tommy", "Male");

            Menu.ViewLogo();
            Console.ReadKey();
            Menu.ViewMainMenu();
            Console.ReadKey();
        }



    }
}
