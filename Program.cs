using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractice
{
    internal class Program
    {
        static void Main()
        {
            Dog dog1 = new() { Age = 5 };
            Dog dog2 = new() { Age = 7 };

            Console.WriteLine(dog1 > dog2);
            Console.WriteLine(dog1 < dog2);
            Console.WriteLine(dog1 == dog2);
            Console.WriteLine(dog1 != dog2);

            Console.WriteLine($"First dog is older? - {dog1 > dog2}");
            Console.WriteLine($"First dog is younger? - {dog1 < dog2}");

        }
    }
}
