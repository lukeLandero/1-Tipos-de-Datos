using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of a bool variable
            bool isTrue = true; // You can change this to false for testing

            // Using an if statement to evaluate the bool variable
            if (isTrue) // If the variable is true, this block executes
            {
                Console.WriteLine("The bool variable has the value: true");
            }
            else // If the variable is false, this block executes
            {
                Console.WriteLine("The bool variable has the value: false");
            }

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit, Thank You!...");
            Console.ReadKey();
        }
    }
}