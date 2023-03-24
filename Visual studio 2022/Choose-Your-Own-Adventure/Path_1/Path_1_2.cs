using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Choose_Your_Own_Adventure.Game;


namespace Choose_Your_Own_Adventure.Path_1
{
    public class Path_1_2
    {
        public static void NaturalSciences()
        {
            Console.Clear();
            Game.Text = "You run into the natural sciences building and walk up the stairs. "
                + "You realise the glass walls for the animals are broken and they are now walking "
                + "around freely. Carefully you make your way through, but you can't be careful "
                + "enough, because you still getting chased, so you rush and oh no. One of the "
                + "poisonous frogs has jumped onto your arm. You throw it off, but it's too late. "
                + "You start to feel dizzy and become slow. It's catching up to you. It grabs "
                + "you by the neck, with his arms, putting your head on it's sholder and jumps "
                + "to the ground with you, while screaming RKO!";
            Typing();
            Game.Text = "You lie there, slowly fading away in pain, because of the poison "
                + "and the damage from it's attack. The last thing you see is the monster "
                + "that just killed you eating it's sandwhich while watching the latest "
                + "iphone announcement.";
            Enter = true;
            Typing();

            Game.Text = "You are dead, maybe your next run will end in a better way.";
            Typing();
            Environment.Exit(0);
        }
    }
}
