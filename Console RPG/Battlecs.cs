using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Console_RPG
{
    class Battle
    {


        public bool isResolved;
        public List<Enemy> enemies;


        public Battle(List<Enemy> enemies )
        {
            this.isResolved = false;
            this.enemies = enemies;


        }


        public void Resolve(List<Player> players)
        {
           
            while (true)
            {

                foreach (var enemy in enemies)
                {  
                   if ( enemy.currentHp > 0 )
                   {
                    Console.WriteLine($"{enemy.name} approaches!");
                    enemy.DoTurn(players, enemies,null);
                    Console.WriteLine($"{enemy.name} did {enemy.stats.attack} damage!");
                    Console.WriteLine("\n");

                   } 
                }






                foreach (var player in players)
                {
                   if (player.currentHp > 0) 
                   {
                      Console.WriteLine("Go forth" + " " + player.name + "..");
                        player.DoTurn(players, enemies, player.moves);

                   }
                }

                // If all players die.
                if (players.TrueForAll(player => player.currentHp <= 0))
                {
                    Console.WriteLine("WHAT.");
                    break;
                }

                if (enemies.TrueForAll(enemy => enemy.currentHp <= 0))
                {
                    Console.WriteLine("woohoo.");
                    break;
                }


            }
 



            // anything that happens no matter no who wins the battle..
        }
    }

}
