using System;
using System.Collections;
using System.Collections.Generic;

namespace CAGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            people.Add(new Person("Ali",  "N"));
            people.Add(new Person("Reem", "S"));


            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Length: {people.Count} items");
            Console.WriteLine($"Empty: {people.Count == 0}");

            Console.WriteLine("-------------------");
            var arr = new ArrayList();
            arr.Add(1);
            arr.Add("Good Morning");
            arr.Add(new Person("Ali", "N"));
            arr.Add(new { FName = "Reem", LName = "S" });
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Length: {arr.Count} items");
            Console.WriteLine($"Empty: {arr.Count == 0}");
            Console.ReadKey();
        } 
    }

    public class Person
    {
        private string fname;
        private string lname;

        public Person(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }
        public override string ToString()
        {
            return $"'{fname} {lname}'";
        }
    }
}
