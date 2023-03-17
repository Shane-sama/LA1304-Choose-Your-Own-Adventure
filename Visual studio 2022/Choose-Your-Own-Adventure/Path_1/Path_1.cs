using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Choose_Your_Own_Adventure.Path_1 
{
    public class Path_1
    {
        public static void Search()
        {
            Console.Clear();
            Game.Text = "You try to search for another way out. You are walking around and find out that "
                      + "you're in the Mensa building. That's really good news hence there are hallways to "
                      + "two different buildings and there could be food somewhere here. One guides to the "
                      + "Sporthalls and one to the Biology Building. "
                      + "While you're thinking about which building you want to go and if you want to search for "
                      + "food first, you suddenly get a weird "
                      + "feeling as if someone is watching you. You should go somewhere else than this "
                      + "place quickly.";

            Game.Enter = true;
            Game.Typing();
            Game.Enter = false;
            Game.Text = "1. Look for another way out.";
            Game.Typing();
            Game.Text = "2. Go back to the classroom and try to wait for the morning.";
            Game.Typing();
            Game.Text = "[Choose your path!]";
            Game.Typing();
    }
    }
}