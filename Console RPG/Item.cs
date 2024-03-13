using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Console_RPG
{



   

    abstract class Item
    {
        public string name;
        public string descryption;
        public int shopPrice;
        public int sellPrice;

        public Item(string name, string descryption, int shopPrice, int sellPrice)
        {
            this.name = name;
            this.descryption = descryption;
            this.shopPrice = shopPrice;
            this.sellPrice = sellPrice;
        }


        public abstract void Use(Entity user, Entity target);



        public static HealthItem chewToy = new HealthItem("The Chew toy.", " MMmmmphhhnnnooMM *squeek...", 10, 5, 2);
        public static HealthItem kibbleBit = new HealthItem("Kibble & bit", "KIBBLLE N BIT!!! THIS IS THE SH-", 15, 8, 14);
        public static SpeedItem dogBooties = new SpeedItem("Dog Booties", "who names shoes booties??", 37, 19, 5);
       
        
    }

    class HealthItem : Item
    {
        public int healAmount;


        public HealthItem(string name, string descryption, int shopPrice, int sellPrice, int healAmount) : base(name, descryption, shopPrice, sellPrice)
        {
            this.healAmount = healAmount; 
        }

        public override void Use(Entity user, Entity target)
        {
            target.currentHp += this.healAmount;
            Console.WriteLine($"{target.name} healed!!! by {this.healAmount} hp!!!! {this.descryption}");
        }
    }

    class SpeedItem : Item
    {
        public int speedGranted;


        public SpeedItem(string name, string descryption, int shopPrice, int sellPrice, int speedGranted) : base(name, descryption, shopPrice,sellPrice)
        {
            this.speedGranted = speedGranted;
        }


        public override void Use(Entity user, Entity target)
        {
            target.stats.speed += this.speedGranted;
            Console.WriteLine($" {target.name} put on the {this.name}, {target.gender} speed went up by {this.speedGranted} SP!!! {this.descryption}");
        }


    }

    class AttackItem : Item
    {
        public int attackGranted;

        public AttackItem(int attackGranted,string name, string descryption, int shopPrice, int sellPrice) : base(name, descryption, shopPrice, sellPrice)
        {
            this.attackGranted = attackGranted;
        }


        public override void Use(Entity user, Entity target)
        {
            target.stats.attack += this.attackGranted;
            Console.WriteLine($" {target.name} ate {this.name}, {target.gender} attack increaased by {this.attackGranted} AP!!! {this.descryption}");
        }
    }

    class DefenseItem : Item
    {
        public int defenseGranted;


        public DefenseItem(int defenseGranted, string name, string descryption, int shopPrice, int sellPrice) : base(name,descryption, shopPrice,sellPrice)
        {
            this.defenseGranted = defenseGranted;
        }

        public override void Use(Entity user, Entity target)
        {
           target.stats.defense += this.defenseGranted;
           Console.WriteLine($" {target.name} ate {this.name}, {target.gender} defense increaased by {this.defenseGranted} DP!!! {this.descryption}");
        }

    }

   

    
}

