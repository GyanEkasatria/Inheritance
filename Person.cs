using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas4
{
    public class Person
    {
        string Name;
        int Age;
        public Person(string person, int age)
        {
            Name = person;
            Age = age;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0} ", Name);
            Console.WriteLine("The person has age  : {0}", Age);
            Console.WriteLine("------------------------------");
        }
    }
}
