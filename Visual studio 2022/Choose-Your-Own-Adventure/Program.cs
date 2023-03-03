using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Choose Your Own Adventure!");
            while (true)
            {
                try
                {
                    Console.WriteLine("Do you want to play a game? [yes | no]");
                    string UserInput = Console.ReadLine();
                    string Play = UserInput.ToLower();
                
                    if (Play == "yes")
                    {
                        Game.Adventure();
                        break;
                    }
                    else if (Play == "no")
                    {
                        Environment.Exit(0);
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