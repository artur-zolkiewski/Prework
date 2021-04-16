using System;
using System.Collections.Generic;

namespace List_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Artur", "Ana", "Felipe" };
            names.Add("Lila");
            names.Add("Justyna");
            names.Remove("Ana");
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
               
            }

            Console.WriteLine(names.Count);

            fibonacii();
            void fibonacii() {
                var fibonacciNumbers = new List<int> {1, 1};

                while (fibonacciNumbers.Count < 20)
                {
                    var value = fibonacciNumbers[fibonacciNumbers.Count - 1];
                    var previous_value = fibonacciNumbers[fibonacciNumbers.Count - 2];

                    fibonacciNumbers.Add(value + previous_value);
                }

                foreach (int number in fibonacciNumbers) {
                    Console.WriteLine(number);
                }

            
            }
        }
    }
}
