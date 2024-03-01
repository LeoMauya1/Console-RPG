using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Console_RPG
{
    class Player : Entity 
    {
       public static Player jPomp = new Player("jPomp", 100, 35, new Stats(15, 20, 40));
       public static Player jj = new Player("jj", 100, 35, new Stats(35, 18, 15));
       public static Player Juincey = new Player("Juincey", 100, 35, new Stats(27, 27, 27));
       public static Player jincent = new Player("jincent", 100, 35, new Stats(5, 20, 40));
       public static Player craig = new Player("craig", 100, 45, new Stats(13, 13, 21));



        public static List <Item> Inventory  = new List <Item> ();

        public Player(String name, int hp, int spunk, Stats stats) : base(name, hp, spunk, stats) { }
        public override void DoTurn(List<Player> players, List<Enemy> enemeis)
        {
            Console.WriteLine("Quick! Act fast.");
            Console.WriteLine("FIGHT | USE ITEM");
            string Descion = Console.ReadLine();
            
            if (Descion == "FIGHT")
            {
               Entity target = ChooseTarget(enemeis.Cast<Entity>().ToList());
               Attack(target);
            }
            else if (Descion == "USE ITEM")
            {

                Item item = ChooseItem(Inventory);
                Entity target = ChooseTarget(players.Cast<Entity>().ToList());
                item.Use(this, target);
                Inventory.Remove(item);
                
            }
        }

        public override void Attack(Entity target)
        {
            Console.WriteLine($"{this.name} attacked {target.name}, ouchie!");
            target.currentHp = target.stats.defense - this.stats.attack;    
        }

        public override Entity ChooseTarget(List<Entity> choices)
        {

            Console.WriteLine(" Type in the number of the entity you want to target");

            // Iterate through each of the choices
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i+1}: { choices [i].name}");
            }

            // Let the user pick a choice.
            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];

        }

        public  Item ChooseItem(List<Item> items)
        {

            Console.WriteLine(" Type in the number of the Item you want to target");

            // Iterate through each of the choices
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i].name}");
            }

            // Let the user pick a choice.
            int index = Convert.ToInt32(Console.ReadLine());
            return items[index - 1];

        }






    }
}
