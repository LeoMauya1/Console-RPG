using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public static Location thePound = new Location("The Pound", " THE ANIMAL SANCTION");
        public static Location animalPark = new Location("The Animal Park", " fun! fun! fun1!!!!1!!");
        public static Location livingRoom = new Location("The Living Room", " wonder where the dead room is!");
        public static Location mapleLane = new Location("Maple Lane", "its peacful here.", new Battle(new List<Enemy> {Enemy.JacynTracy}));
        public static Location kkDinner = new Location("KK's Dinner", " Something smells good..", new Battle(new List<Enemy>() {Enemy.ray,Enemy.Kai}));
        public static Location villaValley = new Location("Villa Valley", " the valley of the elite.");
        public static Location cecilHill = new Location("Cecil Hill", " Cecil Hill! it's reaally calm here ");
        public static Location SuperFarmersMarket = new Location("SuperFarmersMarket", "Dont really get makes this place so super..");
        public static Location SuperDuperFarmersMarket = new Location("SuperDUPERFarmersMarket", "OKAY NOW I GET IT.");
        public static Location LastStop = new Location("The Last Stop", " a chill runs down your back.");
    

       


        public string name;
        public string description;
        public Battle battle;

        public Location north, east, south, west;

        public Location(string name, string description, Battle battle = null)
        {
            this.name = name;
            this.description = description;
            this.battle = battle;
        }


        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {



            if (!(north is null))
            {
                  this.north = north;
                  north.south = this;

            }
           
            
            if (!(east is null))
            {
                 east.west = this;
                 this.east = east;
            }

           
            if(!(south is null ))
            {
                 south.north = this;
                 this.south = south;

            }
           
            if(!(west is null))
            {
                 west.east = this;
                 this.west = west;
            }
        }


        public void Resolve(List<Player> players )
        {

            // only resolve a batlle if there is a battle to resolve.
            battle?.Resolve(players);


            Console.WriteLine("you've arrived at " + this.name + ".");
            Console.WriteLine(this.description);

            if (!(north is null))
                Console.WriteLine("North : " + this.north.name);


            if (!(east is null))
                Console.WriteLine("East: " + this.east.name);



            if (!(south is null))
                Console.WriteLine("South: " + this.south.name);

            if (!(west is null))
                Console.WriteLine("West: " + this.west.name);

            string direction = Console.ReadLine();
            Location nextLocation = null;





            if (direction == "north")
                nextLocation = this.north;
             else if ( direction == "east")
                nextLocation = this.east;
            else if (direction == "south")
                nextLocation = this.south;
            else if (direction == "west")
                nextLocation = this.south;

            nextLocation.Resolve(players);
        }
    }
}
