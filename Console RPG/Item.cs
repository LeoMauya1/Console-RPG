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







    }

    public class healingITem : Item
    {
        public int healAmount;

        public healingITem(string name, string descryption, int shopPrice, int sellPrice, int healAmount) : base(name, descryption, shopPrice, sellPrice)
        {
            {
                this.healAmount = healAmount;
            }



        }



    }
}

