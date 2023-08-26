using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> listOfUsers = new List<User>()
        {
        new User() { Name = "John Doe", Age = 42 },
        new User() { Name = "Jane Doe", Age = 34 },
        new User() { Name = "Joe Doe", Age = 8 },
        };

            foreach (User user in listOfUsers)
            {
                Console.WriteLine($"{user.Name} is {user.Age} years old");
            }
            Console.ReadKey();
        }
    }

    class User
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}