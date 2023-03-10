using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure.Path_2
{
    public class Path_2
    {
        public static void Wait()
        {
            Game.Text = "You go back to the classroom and try to fall asleep using your jacket "
                + "as a pillow. But you can't. You aren't tired anymore and there's this weird "
                + "feeling, as if something is watching. You take out your phone to check the "
                + "time and to watch some videos or play some games to make the time pass by. "
                + "You realise there's no internet connection. Seems like the school turns it "
                + "off during the night. The lights in the room also don't work .They must be "
                + "turning off the electricity for the whole place. That seems like way to much "
                + "effort you think to yourself.";
            Game.Enter = true;
            Game.Typing();
        }
    }
}