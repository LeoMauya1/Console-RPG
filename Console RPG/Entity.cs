using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Console_RPG
{


    abstract class Entity
    {
        public string name;
        public int currentHp, MaxHp;
        public int currentSpunk, maxSpunk;
        public string gender;

        public Stats stats;


        public Entity(String name, int hp, int spunk, Stats stats, string gender)
        {
            this.name = name;
            this.currentHp = hp;
            this.MaxHp = hp;
            this.currentSpunk = spunk;
            this.maxSpunk = spunk;
            this.stats = stats;
            this.gender = gender;
        }

        public abstract void Attack(Entity target);
        public abstract Entity ChooseTarget(List<Entity> choices);
        public abstract Moves  ChooseMove(List<Moves> moves);

        public abstract void DoTurn(List<Player> players, List<Enemy> enemies, List<Moves> moves);

        public void useItem (Item item, Entity target)
        {
            item.Use(this, target);
        }






    }


  

}