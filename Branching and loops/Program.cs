using System;

namespace Branching_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            bool areYouDrunk = false;
            if (age < 18)
                Console.WriteLine($"You are {age} years old. You need to have at least 18 to drink alcohol");
            else if (age >= 18 && areYouDrunk)
                Console.WriteLine("Sorry you are drunk. I can't sell you an ancohol");
            else
                Console.WriteLine("What you want to order?");

            bombCounting();

            void bombCounting() {
                int bombCounter = 10;
                while (bombCounter >= 0)
                {
                    if (bombCounter == 0)
                    {
                        Console.WriteLine("KAAAAAAAABOOOOOOOOOOOOOOOM!!!");
                        break;
                    }
                    else
                        Console.WriteLine(--bombCounter);
                }
            }

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }

            Console.WriteLine(" find the sum of all integers 1 through 20 that are divisible by 3.");
            Console.WriteLine("----------------------------------------------------------------------");

            int sum = 0;
            for (int i = 0; i <= 20; i++) {
                if (i % 3 == 0)
                    sum += i;
            }
            Console.WriteLine(sum);




        }

       
    }
}
