using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Choose_Your_Own_Adventure.Game;


namespace Choose_Your_Own_Adventure.Path_1
{
    public class Path_1_1
    {
        public static void Sporthalls()
        {
            Console.Clear();
            Game.Text = "You are walking in the hallway to the sporthalls. While you're wallking you hear a "
                      + "strange loud high pitched scream coming from the Mensa Building you just were. You're lucky "
                      + "that you didn't need to find out what made that sound. Anyhow, you continue your way to the sporthalls. "
                      + "Right before the stairs to the sporthalls you see alot of apple boxes just laying around. "
                      + "all the apple boxes have the initial C on them. You think that this is very odd so you rather ignore "
                      + "the boxes and go up the stairs. You finally reached your destination. The first thing you wanna do "
                      + "is to look if the doors to the outside are also locked. Sadly they are also locked. Well you didn't expect "
                      + "them to be open anyways. Maybe the backdoor in one of the sportshalls is open! "
                      + "You enter the first sportshall and check if it's open. This one isn't. You make your way to the next "
                      + "sportshall. You open the door and see some kind of shrine in the middle. It's build purely out of apple boxes. "
                      + "the whole shrine is covered with a white fluid. You've never seen something like that before. On top "
                      + "of the srine, there is a shiny blue watch. U decide to take it. You can now always know what time it is. "
                      + "currently it's 3:07am. Sweet! school should start in a few hours. You try out the backdoor of this hall too "
                      + "but it's hopeless again. You hope that the back door of the last hall is open. Right when u enter the last hall "
                      + "you hear that terrible scream from earlier again. It comes from the direction of the hallway you came from. "
                      + "is there something chasing you? You better get out of the sporthalls fast or whatever that is catches up to you. "
                      + "you quickly leave the last sporthall after checking the backdoor. However this time the building looks different. "
                      + "there's a hallway next to you which you've never seen. You guess that it connects to the Mathematics bulding "
                      + "because of the direction. What do you wanna do? ";

            Enter = true;
            Typing();
            Enter = false;
            Game.Text = "1. follow the weird hallway";
            Typing();
            Game.Text = "2. go back to the mensa";
            Typing();
            Game.Text = "3. hide in the sportshalls";
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
                        Path_1_1_1.WeirdHallway();
                        break;
                    }
                    else if (Choice == "2")
                    {
                        Path_1_1_2.MensaDeath();
                        break;
                    }
                    else if (Choice == "3")
                    {
                        Path_1_1_3.HideSports();
                        break;
                    }
                    else if (Choice == "4")
                    {
                        Program.SpeichernUndBeenden(101);
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
