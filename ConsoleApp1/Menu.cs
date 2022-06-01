using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    internal class Menu
    {
        public string[] Options;
        public string Examples;
        public int Selection;


        public Menu(string[] options, string examples, int selection)
        {
            Options = options;
            Examples = examples;
            Selection = selection;
        }

        public void ShowMainMenu()
        {
            Console.WriteLine(Examples);
        }
    }
}
