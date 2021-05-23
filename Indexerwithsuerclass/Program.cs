using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexerwithsuerclass
{
    class Program
    {
       public class User        {
            public string Name { get; set; }
            public string Email { get; set; }
            public  User(string name , string email)
            {
                Name = name;
                Email = email;
            }
        }
        class UserCollection
        {
            Dictionary<string, User> users = new Dictionary<string, User>();

            public User this[string name]
            {
                get => (User)users[name];
                set => users[name] = value;
            }
        }
        static void Main(string[] args)
        {
            var users = new UserCollection();

            // add objects using indexer
            users["julie"] = new User("Julie Lerman", "joelin@indo.com");
            users["mark"] = new User("Mark Lettuce", "mark@lettuce.com");
            users["peter"] = new User("Peter Mbanugo", "p.mbanugo@yahoo.com");

            // obtain and display Mark's data
            Console.WriteLine($"Marks Email: {users["mark"].Email}");
            Console.Read();
            // output
            // User number: 0
            // Name: Julie Lerman
            // Email: joelin@indo.com
            // User number: 1
            // Name: Mark Lettuce
            // Email: mark@lettuce.com
            // User number: 2
            // Name: Peter Mbanugo
            // Email: p.mbanugo@yahoo.com
        }
    }
}
