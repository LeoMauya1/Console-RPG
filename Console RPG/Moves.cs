using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
 
   

        class Moves
        {
            public static Moves JpompMoveSet1 = new Moves("Jump Attack", 13);
            public static Moves JpompMoveSet2 = new Moves("Bash", 10);
            public static Moves JpompMoveSet3 = new Moves("HeadButt", 13);
            public static Moves JpompMoveSet4 = new Moves("Quick Slash", 13);
            public static Moves jjMoveSet1 = new Moves("Body Slam", 10);
            public static Moves jjMoveSet2 = new Moves("QuickPlex", 12);
            public static Moves jjMoveSet3 = new Moves("Bite", 9);
            public static Moves jjMoveSet4 = new Moves("BARK", 10);
            public static Moves JuinceyMovest1 = new Moves("Moderate Slash", 11);
            public static Moves JuinceyMovest2 = new Moves("Blitz", 9);
            public static Moves JuinceyMovest3 = new Moves("Tail Wag", 11);
            public static Moves JuinceyMovest4 = new Moves("Quick Slash", 12);
            public static Moves jincentMoveSet1 = new Moves("Roll Through",14);
            public static Moves jincentMoveSet2 = new Moves("Heavy Bag", 14);
            public static Moves jincentMoveSet3 = new Moves("HeadBUtt", 14);
            public static Moves jincentMoveSet4 = new Moves("Straight Punch", 14);
            public static Moves craigMoveSet1 = new Moves("Knife hand", 7);
            public static Moves craigMoveSet2 = new Moves("Hook Punch", 8);
            public static Moves craigMoveSet3 = new Moves("Slap", 6);
            public static Moves craigMoveSet4 = new Moves("Haymaker", 7);



           public string moveName;
           
            public int assignedNumber;

            
            public Moves(string moveName, int assignedNumber)
            {
                this.moveName = moveName;
                this.assignedNumber = assignedNumber;
               


            }
        }
    
}
