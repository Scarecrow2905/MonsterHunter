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
            var player = new MyCharacter("Tommy", "Male");

            
        
            Console.WriteLine("Write HubList or Inventory: ");


        }




        public static void View()
        {
            while (true)
            {
                string command = Console.ReadLine().ToLower();
                string[] splitCommand = command.Split(' ');

                Console.Clear();

                switch (command)
                {
                    case "HubList":
                        MyHubList();
                        break;

                    case "Inventory":
                        Console.WriteLine("Her kommer inventory. Test!");
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
            hubList.Add(new Palico("Tjodleif", "Support", 1000, 200, 50, 100));
            hubList.Add(new Palico("Paarl", "Tank", 1000, 200, 50, 100));
            hubList.Add(new Palico("Rudy", "Trapper", 1000, 200, 50, 100));

            foreach (var item in hubList)
            {
                //Console.WriteLine("Navn: " + item.Name + ". Class: " + item.Type);
                Console.WriteLine($"Name: {item.Name}. Class: {item.Type}. Health: {item.Health}. ");
            }
        }
    }
}