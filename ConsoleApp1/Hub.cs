using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter
{
    public class Hub // List
    {
        public List<Palico> palicoList;
        public Missions mission;
        public Hub()
        {
            mission = new Missions();
            palicoList = new List<Palico>();
            palicoList.Add(new Palico("Leif", "Support", 1000, 200, 50, 100));
            palicoList.Add(new Palico("Paarl", "Tank", 1000, 200, 50, 100));
            palicoList.Add(new Palico("Rudy", "Trapper", 1000, 200, 50, 100));
        }

            public void View(Menu menu)
            {

                foreach (var item in palicoList)
                {
                    Console.WriteLine(
                        $"Name: {item.Name}. Type: {item.Type}. Health: {item.Health}. Attack: {item.Attack}. Gathering: {item.Gathering}. Exploring {item.Exploring}");
                }

                Console.ReadKey();
                viewOptions(menu);
            }

            public void viewOptions(Menu menu)
            {
                int Selection = 0;
                string front = "";
                menu.Options = new string[]
                {
                    "Back",
                    "Send"
                };

                switch (Selection)
                {
                    case 0:
                        Console.Clear();
                        menu.setMenu();
                        menu.View();
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine("How many to send? ");
                        var userInput = Convert.ToInt32(Console.ReadLine());
                        addSelected(userInput);
                        Console.WriteLine("Palico is sent to the mission list.");
                        Console.ReadLine();
                        menu.View();
                        break;
                }

                Console.ReadKey(true);
            }

            public void addSelected(int userInput)
            {
             
                int Selection = 0;
                string front = "";
                string[] options =
                {
                    "1",
                    "2",
                    "3",
                };

                //Menu hubMenu = new Menu(options, front, Selection);
                //Selection = hubMenu.Run();
                //hubMenu.ShowOptions();
                for (int i = 0; i < userInput; i++)
                {

                    switch (Selection)
                    {
                        case 0:
                            mission.missionList.Add(palicoList[0]);
                            break;
                        case 1:
                            mission.missionList.Add(palicoList[0]);
                            break;
                        case 2:
                            mission.missionList.Add(palicoList[0]);
                            break;


                    }
                }

                foreach (var Palico in mission.missionList)
                {
                    Console.WriteLine(Palico.Name);
                }
                
            }

    }
}
