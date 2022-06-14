using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    public class ItemBox
    {

        public ItemBox()
        {

        }

        public static void View()
        {
            Console.ReadKey(true);
            var itemBox = new List<Item>();
            itemBox.Add(new HealingPotion("First Aid+", "Potion", "Healing 400 hp", 10, true, "Healing Potion"));

            foreach (var item in itemBox)
            {
                Console.WriteLine($"Type: {item.Type}. Name: {item.Name}");
            }

            Console.ReadLine();
        }
    }
}


