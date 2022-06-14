using System;
using System.Collections.Generic;
using System.Data;
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


        public Menu(string[] options, string examples, int Selection)
        {
            Options = options;
            Examples = examples;
            Selection = 0;
        }

        public void ShowOptions()
        {
            Console.WriteLine(Examples);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string front;
                if (i == Selection)
                {
                    front = @" ";

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else
                {
                    front = " ";

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                Console.WriteLine($"{front}{currentOption}");
            }
        }

        public static void ViewMainMenu() // Creds til Kamil!!
        {
            string front = "";
            string[] options =
            {
                "Missions",
                "Farm",
                "Hub",
                "Item box"
            };

            Menu mainMenu1 = new Menu(options, front, 0);
            var Selection = mainMenu1.Run();
            mainMenu1.ShowOptions();
            switch (Selection)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("View Missions");
                    //ViewMissions();
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine("View Farm");
                    //ViewFarm();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("View Hub");
                    Hub.View();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("View Item Box"); 
                    ItemBox.View();
                    break;
            }

            Console.Clear();
        }

        public static void ViewLogo()
        {
            Console.WriteLine(@" 
                  __  __                 _              _    _             _            
                 |  \/  |               | |            | |  | |           | |           
                 | \  / | ___  _ __  ___| |_ ___ _ __  | |__| |_   _ _ __ | |_ ___ _ __ 
                 | |\/| |/ _ \| '_ \/ __| __/ _ \ '__| |  __  | | | | '_ \| __/ _ \ '__|
                 | |  | | (_) | | | \__ \ ||  __/ |    | |  | | |_| | | | | ||  __/ |   
                 |_|  |_|\___/|_| |_|___/\__\___|_|    |_|  |_|\__,_|_| |_|\__\___|_|   ");

            Console.WriteLine("                 Press ENTER");

        }

        public int Run()
        {
            ConsoleKey pressed;
            do
            {
                Console.Clear();
                ShowOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                pressed = keyInfo.Key;
                if (pressed == ConsoleKey.UpArrow)
                {
                    Selection--;
                    if (Selection == -1)
                    {
                        Selection = Options.Length - 1;
                    }
                }
                else if (pressed == ConsoleKey.DownArrow)
                {
                    Selection++;
                    if (Selection == Options.Length)
                    {
                        Selection = 0;
                    }
                }
            } while (pressed != ConsoleKey.Enter);

            return Selection;
        }
    }
}
