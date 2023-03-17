using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Choose_Your_Own_Adventure.Game;

namespace Choose_Your_Own_Adventure.Path_2
{
    public class Path_2_1
    {
        public static void Run()
        {
            Console.Clear();
            Text = "You run. You go down the stairs all the way to the entrence, where you "
                + "were, when looking for the exit. It's still closed, you continue into the "
                + "mensa, to look for a spot to hide in. You keep running, all the way to the "
                + "other side of the building, in hopes that this entrance is still open."
                + "Ouch! You ran into something big. Like a iron wall. You look up, it has "
                + "a face. You slide back on the floor and realise that it's some sort of "
                + "golem or something. You stand up and turn around to run again.";
            Enter = true;
            Typing();

            Enter = false;
        }
    }
}
