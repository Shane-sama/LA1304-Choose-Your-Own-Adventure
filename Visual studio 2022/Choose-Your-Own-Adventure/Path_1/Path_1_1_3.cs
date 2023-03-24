using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Choose_Your_Own_Adventure.Game;

namespace Choose_Your_Own_Adventure.Path_1
{
    internal class Path_1_1_3
    {
        public static void HideSports()
        {
            Console.Clear();
            Game.Text = "You decide to hide in the sporthalls. You hide in the sporthall with the shrine, behind a curtain. Heavy Steps are approaching "
                      + "the sporthall you're in. You decide to breath as quiet as you can and not move an inch. It entered your Sporthall. Your mind is freaking out "
                      + "The creature is speaking. It's saying 'O Holy mother in the sky. Please bless me with more apple products' infront of the shrine. The Ceiling in "
                      + "the sporthall opens up and apple products drop on the ground. Because the ceiling opened up, there's now somehow a blinding light in the sporthall now "
                      + "unluckily the currains you're hiding under are transparent. The creature spots you and begins running towards you while screaming 'MY APPLE PRODUCTS.' "
                      + "You're scared out of your wits and you can't move. All you can do is wait for certain death. ";
            Typing();

            Game.Text = "YOU DIED, GG GO NEXT";
            Typing();

            Environment.Exit(0);
        }
    }
}
