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
            var meny = new Menu();
            meny.ViewLogo();
            Console.ReadKey();
            meny.View();
            Console.ReadKey();
        }
    }
}
