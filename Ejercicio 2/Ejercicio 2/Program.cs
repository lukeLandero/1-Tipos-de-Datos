using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of two int variables
            int integerNumber1 = 15;
            int integerNumber2 = 5;

            // Declaration of a double variable
            double doubleNumber = 3.5;

            // Declaration of a char variable
            char character = 'L';

            // Operation 1: Sum of the two integers
            int sumOfIntegers = integerNumber1 + integerNumber2;
            Console.WriteLine("Sum of the two integers: " + sumOfIntegers);

            // Operation 2: Multiplication of the double by an int
            double multiplication = doubleNumber * integerNumber1;
            Console.WriteLine("Multiplication of the double by an int: " + multiplication);

            // Operation 3: Concatenation of the char with a string
            string concatenatedText = character + " is a letter.";
            Console.WriteLine("Concatenation of the char with a string: " + concatenatedText);

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}