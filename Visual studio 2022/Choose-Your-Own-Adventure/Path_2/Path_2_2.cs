using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Choose_Your_Own_Adventure.Game;

namespace Choose_Your_Own_Adventure.Path_2
{
    public class Path_2_2
    {
        public static void Check()
        {
            Console.Clear();
            Text = "You go into the classroom to see what happened, when you enter the door "
                + "closes behind you. You turn around an someone's standing there. It's giant "
                + "with long arms and a body made of iron. It begins to speak.";

            Text = " I AM THE ALMIGHTY CEDRIC GOLEM AND YOU HAVE INFILTRATED MY HOME, THUS I "
                + "SHALL KILL YOU!";
            Typing();
            Text = "With his long arms he throws you out the window which it had broken. You "
                + "manage to land on you legs, completly breaking them. You look up, from where "
                + "you where thrown from and see the Cedric Golem looking down at you. You "
                + "try to stand up and escape, but you can't your legs aren't able to move at all. "
                + "You look back up at the window and see the Cedric Golem jumping out of the "
                + "window. Directly jumping onto you, with his heavy iron body.";
            Enter = true;
            Typing();

            Text = "You are dead, maybe your next run will end in a better way.";
            Typing();
            Environment.Exit(0);
        }
    }
}
