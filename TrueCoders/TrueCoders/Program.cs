using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            People a = new People(25, "Charlie", "Doyle", "Black");
            People b = new People(32, "Michael", "Doyle", "Black");
            People c = new People(25, "Graham", "Spencer", "Black");

            List<People> AH = new List<People>();

            AH.Add(a);
            AH.Add(b);
            AH.Add(c);

            foreach(var person in AH)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName} Age: {person.Age} Hair Color: {person.HairColor}");
            }
           
        }
    }
}
