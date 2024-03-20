using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Console_RPG
{
    class Player : Entity 
    {
       public static Player jPomp = new Player("jPomp", 100, 35, new Stats(15, 20, 40), "her", new List<Moves>() { Moves.JpompMoveSet1,Moves.JpompMoveSet2,Moves.JpompMoveSet3,Moves.JpompMoveSet4});
       public static Player jj = new Player("jj", 100, 35, new Stats(35, 18, 15), "her", new List<Moves>() { Moves.jjMoveSet1,Moves.jjMoveSet2,Moves.jjMoveSet3,Moves.jjMoveSet4 });
       public static Player Juincey = new Player("Juincey", 100, 35, new Stats(27, 27, 27), "his", new List<Moves>() { Moves.JuinceyMovest1,Moves.JuinceyMovest2,Moves.JuinceyMovest3,Moves.JuinceyMovest4 });
       public static Player jincent = new Player("jincent", 100, 35, new Stats(5, 20, 40), "his", new List<Moves>() { Moves.jincentMoveSet1,Moves.jincentMoveSet2,Moves.jincentMoveSet3,Moves.jincentMoveSet4 });
       public static Player craig = new Player("craig", 100, 45, new Stats(13, 13, 21),"his", new List<Moves>() { Moves.craigMoveSet1,Moves.craigMoveSet2,Moves.craigMoveSet3,Moves.craigMoveSet4 });

        public static List <Item> Inventory  = new List<Item>() { Item.chewToy, Item.dogBooties };
        public List<Moves> moves = new List<Moves>();
        public Player(String name, int hp, int spunk, Stats stats, string gender, List<Moves> moves) : base(name, hp, spunk, stats, gender)
        {
            this.moves = moves;
        }


        public override void DoTurn(List<Player> players, List<Enemy> enemeis, List <Moves> moves)
        {
            Console.WriteLine("Quick! Act fast.");
            Console.WriteLine($"{this.name}'s spunk meter is at {this.currentSpunk}");
            Console.WriteLine("\n");
      
            Console.WriteLine("FIGHT | USE ITEM"); 
            string Descion = Console.ReadLine();
    
            
            if (Descion == "FIGHT" || Descion == "fight")
            {
       
                Moves move = ChooseMove(moves.Cast<Moves>().ToList());
               Entity target = ChooseTarget(enemeis.Cast<Entity>().ToList());
                AttackWithMove(target, move);

            }

            else if (Descion == "USE ITEM")
            {

                Item item = ChooseItem(Inventory);
                Entity target = ChooseTarget(players.Cast<Entity>().ToList());
                item.Use(this, target);
                Inventory.Remove(item);
                
            }
            else
            {
                Console.WriteLine("what? try again");
                System.Threading.Thread.Sleep(2);
                Console.WriteLine("Quick! Act fast.");
                Console.WriteLine($"{this.name}'s spunk meter is at {this.currentSpunk}");
                Console.WriteLine("\n");

                Console.WriteLine("FIGHT | USE ITEM");
                string newDescion = Console.ReadLine();
                if (Descion == "FIGHT" || Descion == "fight")
                {

                    Moves move = ChooseMove(moves.Cast<Moves>().ToList());
                    Entity target = ChooseTarget(enemeis.Cast<Entity>().ToList());
                    AttackWithMove(target, move);

                }
                else if (Descion == "USE ITEM")
                {

                    Item item = ChooseItem(Inventory);
                    Entity target = ChooseTarget(players.Cast<Entity>().ToList());
                    item.Use(this, target);
                    Inventory.Remove(item);

                }
                else
                {
                    Console.WriteLine("what? try again");
                    System.Threading.Thread.Sleep(2);
                    Console.WriteLine("Quick! Act fast.");
                    Console.WriteLine($"{this.name}'s spunk meter is at {this.currentSpunk}");
                    Console.WriteLine("\n");

                    Console.WriteLine("FIGHT | USE ITEM");
                    string newerDescion = Console.ReadLine();
                    if (Descion == "FIGHT" || Descion == "fight")
                    {

                        Moves move = ChooseMove(moves.Cast<Moves>().ToList());
                        Entity target = ChooseTarget(enemeis.Cast<Entity>().ToList());
                        AttackWithMove(target, move);

                    }
                    else if (Descion == "USE ITEM")
                    {

                        Item item = ChooseItem(Inventory);
                        Entity target = ChooseTarget(players.Cast<Entity>().ToList());
                        item.Use(this, target);
                        Inventory.Remove(item);

                    }
                    else
                    {
                        Console.WriteLine("k last try");
                        System.Threading.Thread.Sleep(2);
                        Console.WriteLine("Quick! Act fast.");
                        Console.WriteLine($"{this.name}'s spunk meter is at {this.currentSpunk}");
                        Console.WriteLine("\n");

                        Console.WriteLine("FIGHT | USE ITEM");
                        string newererDescion = Console.ReadLine();
                        if (Descion == "FIGHT" || Descion == "fight")
                        {

                            Moves move = ChooseMove(moves.Cast<Moves>().ToList());
                            Entity target = ChooseTarget(enemeis.Cast<Entity>().ToList());
                            AttackWithMove(target, move);

                        }
                        else if (Descion == "USE ITEM")
                        {

                            Item item = ChooseItem(Inventory);
                            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
                            item.Use(this, target);
                            Inventory.Remove(item);

                        }
                        else
                        {
                            Console.WriteLine("ahhhh ahah just kidding, k this is your last try for real this time.");
                            System.Threading.Thread.Sleep(2);
                            Console.WriteLine("Quick! Act fast.");
                            Console.WriteLine($"{this.name}'s spunk meter is at {this.currentSpunk}");
                            Console.WriteLine("\n");

                            Console.WriteLine("FIGHT | USE ITEM");
                            string newerererDescion = Console.ReadLine();
                            if (Descion == "FIGHT" || Descion == "fight")
                            {

                                Moves move = ChooseMove(moves.Cast<Moves>().ToList());
                                Entity target = ChooseTarget(enemeis.Cast<Entity>().ToList());
                                AttackWithMove(target, move);

                            }
                        }
                    }
                }
            }

           
            


        }



        public void AttackWithMove(Entity target, Moves moves)
        {

            Console.WriteLine($"{this.name} did {moves.assignedNumber} damage to {target.name} using {moves.moveName}, ouchie! ({moves.spunkCost} spunk used)");
            target.currentHp = target.stats.defense - moves.assignedNumber;
            this.currentSpunk = this.currentSpunk - moves.spunkCost;
        }

        public override void Attack(Entity target)
        { 
            Console.WriteLine($" {this.name} attacked {target.name}");
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
        public override Moves ChooseMove(List<Moves> moves)
        {
            Console.WriteLine(" Type in the number of the move you want to use");

            // Iterate through each of the choices
            for (int i = 0; i < moves.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {moves[i].moveName} ");

            }

            // Let the user pick a choice.
            int index = Convert.ToInt32(Console.ReadLine());
           
            return moves[index - 1];
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
