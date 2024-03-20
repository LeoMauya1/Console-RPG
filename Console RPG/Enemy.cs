using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Console_RPG
{
    class Enemy : Entity
    {



        public static Enemy ray = new Enemy("ray", 100, 23, new Stats(34, 23, 43), 23,"his");
        public static Enemy JacynTracy = new Enemy("Jacey & tracy", 35, 33, new Stats(20, 40, 24), 10, "they");
        public static Enemy Kai = new Enemy("kai", 100, 23, new Stats(33, 26, 44), 23, " his");



        public int lifeForce;

        public Enemy(string name, int hp, int spunk, Stats stats, int lifeForce, string gender) : base(name, hp, spunk, stats, gender)
        {

            this.lifeForce = lifeForce;

        }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            Random random = new Random();
            return choices[random.Next(0, choices.Count)];
        }
        public override void Attack(Entity target)
        {
            Console.WriteLine($"{this.name} attacked {target.name}, ouchie!");
            target.currentHp = target.stats.defense - this.stats.attack;
        }

 

        public override void DoTurn(List<Player> players, List<Enemy> enemeis, List<Moves> moves)
        {

            Entity target = ChooseTarget((players.Cast<Entity>().ToList()));
            Attack(target);

        }



        public override Moves ChooseMove(List<Moves> moves)
        {
 

            // Iterate through each of the choices
            for (int i = 0; i < moves.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {moves[i].moveName} ");

            }

            // Let the user pick a choice.
            int index = Convert.ToInt32(Console.ReadLine());
            return moves[index - 1];
        }

    }


}
