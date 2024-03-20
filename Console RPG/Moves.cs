using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
 
   

        class Moves
        {
            public static Moves JpompMoveSet1 = new Moves("Jump Attack", 13, 5);
            public static Moves JpompMoveSet2 = new Moves("Bash", 10, 3);
            public static Moves JpompMoveSet3 = new Moves("HeadButt", 13, 5);
            public static Moves JpompMoveSet4 = new Moves("Quick Slash", 13, 5);
            public static Moves jjMoveSet1 = new Moves("Body Slam", 10, 3);
            public static Moves jjMoveSet2 = new Moves("QuickPlex", 12, 4);
            public static Moves jjMoveSet3 = new Moves("Bite", 9, 3);
            public static Moves jjMoveSet4 = new Moves("BARK", 10, 3);
            public static Moves JuinceyMovest1 = new Moves("Moderate Slash", 11, 5);
            public static Moves JuinceyMovest2 = new Moves("Blitz", 9, 3);
            public static Moves JuinceyMovest3 = new Moves("Tail Wag", 11, 4);
            public static Moves JuinceyMovest4 = new Moves("Quick Slash", 12, 4);
            public static Moves jincentMoveSet1 = new Moves("Roll Through",14,6);
            public static Moves jincentMoveSet2 = new Moves("Heavy Bag", 14, 6);
            public static Moves jincentMoveSet3 = new Moves("HeadBUtt", 14, 6);
            public static Moves jincentMoveSet4 = new Moves("Straight Punch", 14, 6);
            public static Moves craigMoveSet1 = new Moves("Knife hand", 7,2);
            public static Moves craigMoveSet2 = new Moves("Hook Punch", 8,2);
            public static Moves craigMoveSet3 = new Moves("Slap", 6,2);
            public static Moves craigMoveSet4 = new Moves("Haymaker", 7, 2);



           public string moveName;
           
           public int assignedNumber;

           public int spunkCost;
            
            public Moves(string moveName, int assignedNumber, int spunkCost)
            {

                this.spunkCost = spunkCost;
                this.moveName = moveName;
                this.assignedNumber = assignedNumber;
               


            }
        }
    
}
