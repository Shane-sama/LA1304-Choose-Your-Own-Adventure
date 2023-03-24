using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Choose_Your_Own_Adventure.Game;

namespace Choose_Your_Own_Adventure.Path_2
{
    public class Path_2_1_1
    {
        public static void BackUp()
        {
            Console.Clear();
            Text = "You run, all the way up to the top floor of the building, where you woke up. "
                + "You feel a weird feeling, making you decide to go to the Room where you "
                + "heared the window breaking earlier. When you walk into the room you see "
                + "the big iron creatur again. It's standing there menacingly, looking you right "
                + "into the eyes. It begins to speak and begins to speak.";
            Typing();
            Text = " I AM THE ALMIGHTY CEDRIC GOLEM AND YOU HAVE INFILTRATED MY HOME, THUS I "
                + "SHALL KILL YOU!";
            Typing();
            Text = "With his long arms he throws you in the air. You hit the ceiling and die "
                + "due to the impact.";
            Enter = true;
            Typing();

            Text = "You are dead, maybe your next run will end in a better way.";
            Typing();
            Environment.Exit(0);
        }
    }
}
