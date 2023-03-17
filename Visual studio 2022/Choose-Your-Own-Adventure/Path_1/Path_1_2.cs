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
        public static void Biology()
        {
            Console.Clear();
            Game.Text = "You try to search for another way out. You are walking around and find out that "
                      + "you're in the Mensa building. That's really good news hence there are hallways to "
                      + "two different buildings and there could be food somewhere here. One guides to the "
                      + "Sporthalls and one to the biology building. "
                      + "While you're thinking about which building you want to go and if you want to search for "
                      + "food first, you suddenly get a weird "
                      + "feeling as if someone is watching you. You should go somewhere else than this "
                      + "place quickly. What do you want to do? ";

            Enter = true;
            Typing();
            Enter = false;
            Game.Text = "1. Go to the Sporthalls";
            Typing();
            Game.Text = "2. Go to the biology building";
            Typing();
            Game.Text = "3. Search for food before going anywhere";
            Typing();
            Game.Text = "4. Save and Exit";
            Typing();
            Game.Text = "[Choose your path!]";
            Typing();
            Enter = true;

            while (true)
            {
                try
                {
                    string Choice = Console.ReadLine();

                    if (Choice == "1")
                    {
                        Path_1_1.Sporthalls();
                        break;
                    }
                    else if (Choice == "2")
                    {
                        Path_1_2.Biology();
                        break;
                    }
                    else if (Choice == "3")
                    {
                        Path_1_3.FoodMensa();
                        break;
                    }
                    else if (Choice == "4")
                    {
                        Program.SpeichernUndBeenden(100);
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid answer!");
                }
            }
        }
    }
}
