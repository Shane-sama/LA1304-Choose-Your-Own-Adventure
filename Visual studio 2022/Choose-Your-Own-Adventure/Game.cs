using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Choose_Your_Own_Adventure
{
    public class Game
    {
        public static string Text = "";
        public static bool Enter = true;

        public static void Typing()
        {
            foreach (char c in Text)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            if (Enter == true)
            {
                Console.WriteLine("");
                Console.WriteLine("[press enter to continue]");
                while (true)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }

        public static void Adventure()
        {
            Text = "You wake up. You only remember having school not too long ago. "
                + "You must have fallen asleep. Nobody's in the calssroom anymore. " +
                "It's dark outside, so you decide that you want to go home. You stand up " +
                "and walk down the stairs to the entrance. Unluckily the door is locked.";
            Typing();

            Enter = false;
            Text = "1. Look for another way out.";
            Typing();
            Text = "2. Go back to the classroom and try to wait for the morning.";
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
                        Path_1.Path_1.Search();
                        break;
                    }
                    else if (Choice == "2")
                    {
                        Path_2.Path_2.Wait();
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