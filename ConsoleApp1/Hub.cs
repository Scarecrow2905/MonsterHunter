using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    public class Hub : List<Palico>
    {
        public Hub()
        {
            Add(new Palico("Leif", "Support", 1000, 200, 50, 100));
        }

        public static void View()
        {
            Console.ReadKey(true); // < --- Husk denne!!!
            var hubList = new List<Palico>(3);
            hubList.Add(new Palico("Leif", "Support", 1000, 200, 50, 100));
            hubList.Add(new Palico("Paarl", "Tank", 1000, 200, 50, 100));
            hubList.Add(new Palico("Rudy", "Trapper", 1000, 200, 50, 100));

            foreach (var item in hubList)
            {
                Console.WriteLine($"Name: {item.Name}. Class: {item.Type}. Health: {item.Health}.");
            }

            Console.ReadLine();
        }

    }
}
