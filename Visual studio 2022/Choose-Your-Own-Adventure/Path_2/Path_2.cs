using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Choose_Your_Own_Adventure.Game;

namespace Choose_Your_Own_Adventure.Path_2
{
    public class Path_2
    {
        public static void Wait()
        {
            Console.Clear();
            Game.Text = "You go back to the classroom and try to fall asleep using your jacket "
                + "as a pillow. But you can't. You aren't tired anymore and there's this weird "
                + "feeling, as if something is watching. You take out your phone to check the "
                + "time and to watch some videos or play some games to make the time pass by. "
                + "You realise there's no internet connection. Seems like the school turns it "
                + "off during the night. The lights in the room also don't work. They must be "
                + "turning off the electricity for the whole place. That seems like way too much "
                + "effort you think to yourself. You stand up and go outside the room. ";
            Typing();
            Game.Text = "HOLY MOTHER OF GOD! There's someone else in the building. You just "
                + "saw them walking around the corner. You try to follow them, but when you turn "
                + "around the corner, there's noone. "
                + "Suddenly you hear a window breaking. The sound's coming from one of the "
                + "classrooms. What do you do?";
            Enter = true;
            Typing();

            Enter = false;
            Game.Text = "1. RUN!";
            Typing();
            Game.Text = "2. Check out what happened.";
            Typing();
            Game.Text = "3. Save and Exit";
            Typing();
            Game.Text = "[Choose your path!]";
            Typing();


            while (true)
            {
                try
                {
                    string Choice = Console.ReadLine();

                    if (Choice == "1")
                    {
                        
                        break;
                    }
                    else if (Choice == "2")
                    {
                        
                        break;
                    }
                    else if (Choice == "3")
                    {
                        Program.SpeichernUndBeenden(2);
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