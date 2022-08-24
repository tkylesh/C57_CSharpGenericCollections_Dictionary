using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExamps.Models;

namespace DictionaryExamps
{
    class Program
    {
        static void Main()
        {
            //Ex. 2 -Dicionary<TKey,TValue>
            /*rather than obtaining an item from a List<T> using a numerical identifier,
            you could us a unique text key*/
            //Key can be any type but must be unique, if not you wil get a runtime exception

            //Populate using Add Method
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 39 });
            peopleA.Add("Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 37 });
            peopleA.Add("Bart", new Person { FirstName = "Bart", LastName = "Simpson", Age = 10 });

            //Get Homer
            Person homer = peopleA["Homer"];
            Console.WriteLine(homer.Stringify());

            //Populate with initialization syntax
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>
            {
                {"Homer", new Person {FirstName="Homer", LastName="Simpson", Age=39}},
                {"Marge", new Person {FirstName="Marge", LastName="Simpson", Age=37}},
                {"Bart", new Person {FirstName="Bart", LastName="Simpson", Age=10}}
            };

            //Get Marge
            // Person marge = peopleB["Marge"];
            // Console.WriteLine(marge.Stringify());

            //Dictionary Initialization syntax
            //use the indexer to specify the key
            Dictionary<string, Person> peopleC = new Dictionary<string, Person>
            {
                ["Homer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 39 },
                ["Marge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 37 },
                ["Bart"] = new Person { FirstName = "Bart", LastName = "Simpson", Age = 10 }
            };

            //Enumeration
            foreach (KeyValuePair<string, Person> p in peopleC)
                Console.WriteLine($"{p.Key}: {p.Value.Stringify()}");

        }
    }
}
