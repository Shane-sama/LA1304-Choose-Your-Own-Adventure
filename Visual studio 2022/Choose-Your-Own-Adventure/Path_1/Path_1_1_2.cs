using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Choose_Your_Own_Adventure.Game;

namespace Choose_Your_Own_Adventure.Path_1
{
    internal class Path_1_1_2
    {
        public static void MensaDeath()
        {
            Console.Clear();
            Game.Text = "You decide to go back to the mensa even tho the cause of the scream should be in the hallway. You're walking in the hallway when you"
                      + "hear someone screaming 'ALMIGHTY CEDRIC GOLEM PUSH.' fast, heavy steps are coming closer and closer. You decide to run but the steps are"
                      + "still coming closer. You can't outrun it. You don't even wanna look behind. You run with all your might but eventually you"
                      + "got crushed to death by the creature";
            Typing();

            Game.Text = "YOU DIED, GG GO NEXT";
            Typing();

            Environment.Exit(0);
        }
    }
}
