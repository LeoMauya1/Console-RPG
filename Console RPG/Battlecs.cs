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
                    enemy.DoTurn(players, enemies);

                   } 
                }






                foreach (var player in players)
                {
                   if (player.currentHp > 0) 
                   {
                      Console.WriteLine("Go forth" + " " + player.name + "..");
                        player.DoTurn(players, enemies);

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
                    Console.WriteLine("WHAT.");
                    break;
                }


            }

            // anything that happens no matter no who wins the battle..
        }
    }

}
