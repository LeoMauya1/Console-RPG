using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Console_RPG
{
    class Program
    {


        static void Main(string[] args)
        {





            Location.livingRoom.SetNearbyLocations(north: Location.mapleLane);
            Location.mapleLane.SetNearbyLocations(north: Location.animalPark, south: Location.livingRoom);
            Location.animalPark.SetNearbyLocations(south: Location.mapleLane, north: Location.kkDinner, east: Location.thePound);
            Location.thePound.SetNearbyLocations(north: Location.kkDinner, east: Location.animalPark);
            
            
            Location.livingRoom.Resolve(new List<Player>(){Player.jPomp, Player.jj, Player.Juincey, Player.jincent, Player.craig});




           
        }

    }


    
}
