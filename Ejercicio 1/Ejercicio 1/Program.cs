using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of an int variable
            int integerNumber = 95;
            Console.WriteLine("Value of the int variable: " + integerNumber);

            // Declaration of a float variable
            float floatingNumber = 33.14f; // Note: 'f' is added to indicate it's a float
            Console.WriteLine("Value of the float variable: " + floatingNumber);

            // Declaration of a double variable
            double doubleNumber = 56.141592453589793;
            Console.WriteLine("Value of the double variable: " + doubleNumber);

            // Declaration of a char variable
            char character = 'L'; // A single character enclosed in single quotes
            Console.WriteLine("Value of the char variable: " + character);

            // Declaration of a string variable
            string text = "Hello, world! I am Luke Skywalker and I will destroy the entire galaxy!";
            Console.WriteLine("Value of the string variable: " + text);

            // Declaration of a bool variable
            bool isTrue = true; //Se puede cambiar a false y retornara false
            Console.WriteLine("Value of the bool variable: " + isTrue);

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit and may the force be with you!...");
            Console.ReadKey();
        }
    }
}