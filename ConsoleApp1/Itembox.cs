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
            itemBox.Add(new HealingPotion("First Aid+", "Potion", "Healing 400 over 5 sec hp", 10, true, "Healing Potion"));
            itemBox.Add(new HealingPotion("Healing Powder", "Potion", "Healing 200 included teammates hp", 3, false, "Healing Potion"));
            itemBox.Add(new HealingPotion("Max Potion", "Potion", "Heals and restores to your max HP", 50, false, "Healing Potion"));


            foreach (var item in itemBox)
            {
                Console.WriteLine($"Type: {item.Type}. Name: {item.Name}");
            }

            Console.ReadLine();
        }
    }
}


