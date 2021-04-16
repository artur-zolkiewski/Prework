using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = 5;
            int add = a + b;
            int substraction = a - b;
            int multiple = a * b;
            int division = a / b;
            int multiple_operations = (a * multiple) + b;
            int multiple_operations2 = (a * add) -6 + b+ (3 *17) /b +12;
            int modulo = a % c;
           
            Console.WriteLine("Basic Math Operations");
            Console.WriteLine();
            Console.WriteLine($"Dodawanie: {a} + {b} = " + add);
            Console.WriteLine($"Odejmowanie: {a} - {b} = "+ substraction);
            Console.WriteLine($"Mnożenie: {a} * {b} = " + multiple);
            Console.WriteLine($"Dzielenie: {a} / {b} = " + division);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Multiple basic Math Operations");
            Console.WriteLine();
            Console.WriteLine(multiple_operations);
            Console.WriteLine(multiple_operations2);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Additional operation like precisions and modulo");
            Console.WriteLine();
            Console.WriteLine($"Modulo from {a} and {c} equals to: " + modulo);
            Console.WriteLine("Max INT value " + int.MaxValue);
            Console.WriteLine("Min INT value " + int.MinValue);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Double precision");
            double x = 19;
            double y = 23;
            double z = 8;
            double q = (x + y) / z;
            Console.WriteLine(q);
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            double diameter = 2.5;
            double circleArea = Math.PI * diameter * diameter;
            Console.WriteLine($"Pole koła o priomieniu {diameter} wynosi: {circleArea}");

            double side = 5.6;
            double heigh = 2.3;
            double poleTrojkata = 0.5 * side * heigh;
            Console.WriteLine($"Pole trójkąta o boku {side} i wysokości {heigh} wynosi {poleTrojkata}");


        }
        
    }
}
