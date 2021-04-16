using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Artur";
            string lastName = "Żółkiewski";
            string gretting = "    Hello World     ";



            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine($"Hello {name}!");

            Console.WriteLine($"{name} {lastName} this is my full name");
            Console.WriteLine($"My name has {name.Length} letter");
            Console.WriteLine($"My last name has {lastName.Length} letter");


            Console.WriteLine($"[{gretting}]");
            string trimmedGretting = gretting.TrimStart();
            Console.WriteLine($"[{ trimmedGretting}]");
            trimmedGretting = gretting.TrimEnd();
            Console.WriteLine($"[{ trimmedGretting}]");

            trimmedGretting = gretting.Trim();
            Console.WriteLine($"[{ trimmedGretting}]");

            Console.WriteLine($"Upper case greetings without spaces {trimmedGretting.ToUpper()}");

            Console.WriteLine(trimmedGretting.Contains("Hello"));
            Console.WriteLine(trimmedGretting.Contains("hello"));

            Console.WriteLine(trimmedGretting.StartsWith("hello"));
            Console.WriteLine(trimmedGretting.StartsWith("Hello"));
        }
    }
}
