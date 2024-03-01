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

        public Stats stats;


        public Entity(String name, int hp, int spunk, Stats stats)
        {
            this.name = name;
            this.currentHp = hp;
            this.MaxHp = hp;
            this.currentSpunk = spunk;
            this.maxSpunk = spunk;
            this.stats = stats;
        }

        public abstract void Attack(Entity target);
        public abstract Entity ChooseTarget(List<Entity> choices);

        public abstract void DoTurn(List<Player> players, List<Enemy> enemies);

        public void useItem (Item item, Entity target)
        {
            item.Use(this, target);
        }






    }


  

}