using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_and_merge_conflicts
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public void PrintPerson()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Email);
        }
    }
}
