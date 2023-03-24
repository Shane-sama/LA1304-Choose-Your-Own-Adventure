using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Choose_Your_Own_Adventure.Game;

namespace Choose_Your_Own_Adventure.Path_2
{
    public class Path_2_1
    {
        public static void Run()
        {
            Console.Clear();
            Text = "You run. You go down the stairs all the way to the entrence, where you "
                + "were, when looking for the exit. It's still closed, you continue into the "
                + "mensa, to look for a spot to hide in. You keep running, all the way to the "
                + "other side of the building, in hopes that this entrance is still open."
                + "Ouch! You ran into something big. Like a iron wall. You look up, it has "
                + "a face. You slide back on the floor and realise that it's some sort of "
                + "golem or something. You stand up and turn around to run again. You feel "
                + "the ground shaking while it's trying to catch up. This building is connected "
                + "to 2 other ones. There must be a way to escape.";
            Typing();
            Text = "Quick! You have to make a decision!";
            Enter = true;
            Typing();

            Enter = false;
            Text = "1. Go up the stairs again.";
            Typing();
            Text = "2. Go to the natural sciences building";
            Typing();
            Text = "3. Go to the Sporthalls";
            Typing();
            Text = "4. Save and Exit";
            Typing();
            Text = "[Choose your path!]";
            Typing();


            while (true)
            {
                try
                {
                    string Choice = Console.ReadLine();

                    if (Choice == "1")
                    {
                        Path_2_1_1.BackUp();
                        break;
                    }
                    else if (Choice == "2")
                    {
                        Path_1.Path_1_2.Naturalsciences();
                        break;
                    }
                    else if (Choice == "3")
                    {
                        Path_1.Path_1_1.Sporthalls();
                        break;
                    }
                    else if (Choice == "4")
                    {
                        Program.SpeichernUndBeenden(201);
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
