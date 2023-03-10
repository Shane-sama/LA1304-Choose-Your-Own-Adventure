using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MongoDB.Driver;
using MongoDB.Driver.Core.Authentication;
using MongoDBAdventureApp;

namespace Choose_Your_Own_Adventure
{
    class Program
    {
        static void Main()
        {
            Start();
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
            string connctionString = "mongodb+srv://Tim:RSzzVD0wDGVTexSl@adventuregame.x9ezgst.mongodb.net/?retryWrites=true&w=majority";
            string databaseName = "AdventureGame";
            string collectionName = "User";



            var client = new MongoClient(connctionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<PersonModel>(collectionName);

            //Input in Database
            /*var Person = new PersonModel { Username = "Test", Password = "Test", Level = "1" };
            await collection.InsertOneAsync(Person);*/

            //Search in Database
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
            
        }
    }
}