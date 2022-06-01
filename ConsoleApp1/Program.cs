using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            var healingpotion = new HealingPotion();
            var player = new MyCharacter("Tommy", "Male");

            
        
            Console.WriteLine("Where would you like to go? ");
            View();
            

        }




        public static void View()
        {
            while (true)
            {
                string command = Console.ReadLine().ToLower();
                //string[] splitCommand = command.Split(' ');

                Console.Clear();

                switch (command)
                {
                    case "Hub":
                        MyHubList();
                        break;

                    case "Itembox":
                        Console.WriteLine("Her kommer inventory. Test!");
                        break;

                    case "Barracks":
                        Console.WriteLine("Her kommer barracks. Test!");
                        break;

                    default:
                        Console.WriteLine("Command is not available.");
                        break;
                }
            }
        }

        public static void MyHubList() 
        {
            var hubList = new List<Palico>(3);
            hubList.Add(new Palico("Leif", "Support", 1000, 200, 50, 100));
            hubList.Add(new Palico("Paarl", "Tank", 1000, 200, 50, 100));
            hubList.Add(new Palico("Rudy", "Trapper", 1000, 200, 50, 100));

            foreach (var item in hubList)
            {
                //Console.WriteLine("Navn: " + item.Name + ". Class: " + item.Type);
                Console.WriteLine($"Name: {item.Name}. Class: {item.Type}. Health: {item.Health}.");
            }
        }
    }
}