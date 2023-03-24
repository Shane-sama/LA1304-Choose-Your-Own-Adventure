using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Choose_Your_Own_Adventure.Path_1;
using Microsoft.VisualBasic;
using MongoDB.Driver;
using MongoDB.Driver.Core.Authentication;
using MongoDB.Driver.Core.Events;
using MongoDBAdventureApp;

namespace Choose_Your_Own_Adventure
{
    class Program
    {
        public static string Username = "";
        static void Main()
        {
            Start();
        }



        static void Path_0()
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
        static async void Start()
        {
            //Database Connection
            /*string connctionString = "mongodb+srv://Tim:RSzzVD0wDGVTexSl@adventuregame.x9ezgst.mongodb.net/?retryWrites=true&w=majority";
            string databaseName = "AdventureGame";
            string collectionName = "User";

            var client = new MongoClient(connctionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<PersonModel>(collectionName);*/

            ConnectionCheck();
            Login();


            //Input in Database
            /*var Person = new PersonModel { Username = "Test", Password = "Test", Level = "1" };
            await collection.InsertOneAsync(Person);*/

            //Output all
            /*var results = await collection.FindAsync(_ => true);
            foreach(var result in results.ToList())
            {
                Console.WriteLine($"{result.Id}: {result.Username} {result.Password} {result.Level}");
            }*/

            //Update Database
            /*var filter = Builders<PersonModel>.Filter.Eq("Username", "Nathan");
            var update = Builders<PersonModel>.Update
                .Set("Level", "8");
            collection.UpdateOne(filter, update);*/

            //Filter
            /*var filter = Builders<PersonModel>.Filter.Eq("Username", "Shane");
            var filterresults = collection.Find(filter).ToList();
            foreach(var result in filterresults.ToList())
            {
                Console.WriteLine($"{result.Id} {result.Username} {result.Password} {result.Level}");
            }*/

        }

        static void ConnectionCheck()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("connecting to database...");
                    string connctionString = "mongodb+srv://Tim:RSzzVD0wDGVTexSl@adventuregame.x9ezgst.mongodb.net/?retryWrites=true&w=majority";
                    string databaseName = "AdventureGame";
                    string collectionName = "User";

                    var client = new MongoClient(connctionString);
                    var db = client.GetDatabase(databaseName);
                    var collection = db.GetCollection<PersonModel>(collectionName);




                    var filter = Builders<PersonModel>.Filter.Eq("Username", "ConnectionCheck");
                    var filterresults = collection.Find(filter).ToList();
                    foreach (var result in filterresults.ToList())
                    {
                        Console.WriteLine($"{result.Username} {result.Level}");
                        Console.WriteLine("Connected");
                    }

                    Console.Clear();
                    break;
                }
                catch
                {
                    Console.WriteLine("connection refused");
                    Console.WriteLine("trying again");
                }
            }
        }

        static void Login()
        {
            Console.Clear();
            while (true)
            {
                try
                {
                    Console.WriteLine("Do you want to sign in? [yes | no]");
                    string UserInput = Console.ReadLine();
                    string Play = UserInput.ToLower();

                    if (Play == "yes")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (Play == "no")
                    {
                        Console.Clear();
                        Register();
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid answer!");
                }
            }

            string LoginUsername;
            string LoginPassword = "null";
            int ActuelLevel = 0;

            string connctionString = "mongodb+srv://Tim:RSzzVD0wDGVTexSl@adventuregame.x9ezgst.mongodb.net/?retryWrites=true&w=majority";
            string databaseName = "AdventureGame";
            string collectionName = "User";

            var client = new MongoClient(connctionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<PersonModel>(collectionName);

            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Whats your Username?");
                        LoginUsername = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid answer!");
                    }
                }

                Username = LoginUsername;
                var filter = Builders<PersonModel>.Filter.Eq("Username", LoginUsername);
                var filterresults = collection.Find(filter).ToList();
                foreach (var result in filterresults.ToList())
                {
                    Console.WriteLine($"{result.Id} {result.Username} {result.Password} {result.Level}");

                    while (true)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Whats the Password from " + LoginUsername + "?");
                                LoginPassword = Console.ReadLine();
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid answer!");
                            }
                        }


                        if(LoginPassword == result.Password)
                        {
                            ActuelLevel = Convert.ToInt32(result.Level);

                            switch (ActuelLevel)
                            {
                                case 100:
                                    Path_1.Path_1.Search();
                                    break;
                                case 101:
                                    Path_1.Path_1_1.Sporthalls();
                                    break;
                                case 200:
                                    Path_2.Path_2.Wait(); 
                                    break;
                                case 201:
                                    Path_2.Path_2_1.Run();
                                    break;
                                default:
                                    Path_0();
                                    break;
                            }
                        }

                    }
                }



            }
        }

        static void Register()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Do you want to register? [yes | no]");
                    string UserInput = Console.ReadLine();
                    string Play = UserInput.ToLower();

                    if (Play == "yes")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (Play == "no")
                    {
                        Console.Clear();
                        Login();
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid answer!");
                }
            }


            while (true)
            {
                try
                {
                    string NewUsername = "ConnectionCheck";
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Choose a username");
                        try
                        {
                            NewUsername = Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid answer!");
                        }
                    }


                    string connctionString = "mongodb+srv://Tim:RSzzVD0wDGVTexSl@adventuregame.x9ezgst.mongodb.net/?retryWrites=true&w=majority";
                    string databaseName = "AdventureGame";
                    string collectionName = "User";

                    var client = new MongoClient(connctionString);
                    var db = client.GetDatabase(databaseName);
                    var collection = db.GetCollection<PersonModel>(collectionName);


                    int Login = 0;

                    var filter = Builders<PersonModel>.Filter.Eq("Username", NewUsername);
                    var filterresults = collection.Find(filter).ToList();
                    foreach (var result in filterresults.ToList())
                    {
                        Login = filterresults.Count;
                    }

                    
                    
                    
                    string NewPassword;

                    if(Login >= 1)
                    {
                        Console.Clear();
                        Console.WriteLine("The Username " + NewUsername + " is already taken");
                    }
                    else
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Choose your Password.");
                                NewPassword = Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid answer!");
                            }
                        }
                        var Person = new PersonModel { Username = NewUsername, Password = NewPassword, Level = "1" };
                        collection.InsertOneAsync(Person);
                        Username = NewUsername;
                        Path_0();
                    }


                }
                catch
                {
                    Console.Clear();
                }
            }
        }

        public static void SpeichernUndBeenden(int Level)
        {
            string connctionString = "mongodb+srv://Tim:RSzzVD0wDGVTexSl@adventuregame.x9ezgst.mongodb.net/?retryWrites=true&w=majority";
            string databaseName = "AdventureGame";
            string collectionName = "User";

            var client = new MongoClient(connctionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<PersonModel>(collectionName);


            var filter = Builders<PersonModel>.Filter.Eq("Username", Username);
            var update = Builders<PersonModel>.Update
                .Set("Level", Level);
            collection.UpdateOne(filter, update);
            Console.Clear();
            Console.WriteLine("saved");
            Environment.Exit(0);
        }
    }
}