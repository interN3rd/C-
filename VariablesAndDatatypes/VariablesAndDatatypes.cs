// This code was written in Microsoft Visual Studio Enterprise 2019 IDE
// Date (format YYYY-MM-DD): 2022-01-16

using System;

    namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delcare some basic value type variables
            int number = 10;
            float anotherNumber = 2.0f;
            decimal decimalNumber = 10.0m;
            bool isBoolean = true;
            char letter = 'c';

            // Declare a string - it's a collection of characters
            string greeting = "Hello fellow human being who is interested in programming.";

            // Declare an implicit variable
            var alsoANumber = 10;
            var alsoAString = "Hello!";

            // Declare an array of values
            int[] variables = new int[5];
            string[] strings = { "one", "two", "three" };

            // Print the values using a Formatting String
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", number, anotherNumber, decimalNumber, isBoolean, letter, alsoANumber, alsoAString);
        }
    }
}