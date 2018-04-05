using System;
using System.Collections.Generic;
using System.Linq;
using DbConnection;

namespace SimpleCRUD
{
    class Program
    {
        public static void Show(){
            var users = DbConnector.Query("SELECT * FROM users");
            foreach (var user in users){
                foreach(KeyValuePair<string, object> entry in user){
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }
        }
        public static void Create(){
            Console.WriteLine("Create a New User");
            Console.WriteLine("Add First Name:");
            string Fname = Console.ReadLine();
            Console.WriteLine("Now add a Last Name");
            string Lname = Console.ReadLine();
            Console.WriteLine("Lastly Add the Favorite Number");
            string FavNum = Console.ReadLine();
            var query = $"INSERT INTO users (FirstName, LastName, FavoriteNumber) VALUES ('{Fname}', '{Lname}', {FavNum})";
            DbConnector.Execute(query);
            Show();
        }
        static void Main(string[] args)
        {
            Show();
            // Create();
        }
    }
}
