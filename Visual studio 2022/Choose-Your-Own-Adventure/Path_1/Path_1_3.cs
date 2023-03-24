using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Choose_Your_Own_Adventure.Game;

namespace Choose_Your_Own_Adventure.Path_1
{
    public class Path_1_3
    {
        public static void FoodMensa()
        {
            Console.Clear();
            Game.Text = "You decide to search for food first because you're really hungry. You search the kitchen. "
                      + "You hear alot of strange noises which you hadn't heard before. Also the feeling as if "
                      + "something terrible is approaching, is getting stronger and stronger. You finally found some food. "
                      + "A chicken Sandwich. You pick it up from the ground. As you're lifting your body back up, you hit something with your back "
                      + "You turn around and you see something really terrible! A big Monster which appears to be made out of iron! "
                      + "You can't move out of shock. It slowly lowers it face towards your face. You feel its hot and wet breath which smells like "
                      + "iron in your face. You really want to run away but your legs won't move. The monster screams something at you. It sounds "
                      + "like he's screaming 'CEEEDRICCCC GOLLEEMMMMMM'. The sound suddenly dissappears. However you can see that the Monster is still screaming "
                      + "You feel some kind of liquid dripping down your ears as your vision slowly darkens until it's pitch black.";

            
            Typing();
            
            Game.Text = "YOU DIED, GG GO NEXT";
            Typing();

            Environment.Exit(0);
            
        }
    }
}
