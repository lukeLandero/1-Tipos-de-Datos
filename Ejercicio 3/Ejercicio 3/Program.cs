using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of a double variable
            double doubleNumber = 654.456;

            // Conversion from double to int (decimal places are lost)
            int integerNumber = (int)doubleNumber; // Explicit casting
            Console.WriteLine("Original value (double): " + doubleNumber);
            Console.WriteLine("Converted value to int: " + integerNumber);

            // Declaration of an int variable
            int originalInteger = 47;

            // Conversion from int to double
            double convertedDouble = originalInteger; // Implicit conversion
            Console.WriteLine("\nOriginal value (int): " + originalInteger);
            Console.WriteLine("Converted value to double: " + convertedDouble);

            // Keep the console open until the user presses a key
            Console.WriteLine("\nPress any key to exit brother...");
            Console.ReadKey();
        }
    }
}