namespace CalculatorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Assignment");

            // Assignment 1: Return the sum of a and b.
            Console.WriteLine("Assignment 1: Return the sum of a and b.");
            Console.WriteLine("Sum(1, 2) = " + Calculator.Sum(1, 2));

            // Assignment 2: Return the result of dividing a by b.
            Console.WriteLine("Assignment 2: Return the result of dividing a by b.");
            Console.WriteLine("Divide(1, 2) = " + Calculator.Divide(1, 2));

            // Assignment 3: Return the result of multiplying a by b.
            Console.WriteLine("Assignment 3: Return the result of multiplying a by b.");
            Console.WriteLine("Multiply(1, 2) = " + Calculator.Multiply(1, 2));

            // Assignment 4: Return the result of subtracting b from a.
            Console.WriteLine("Assignment 4: Return the result of subtracting b from a.");
            Console.WriteLine("Subtract(1, 2) = " + Calculator.Subtract(1, 2));

            // Assignment 5: Return the result of converting pounds to kg.
            Console.WriteLine("Assignment 5: Return the result of converting pounds to kg.");
            Console.WriteLine("ConvertPoundsToKg(1) = " + Calculator.ConvertPoundsToKg(1));

            // Assignment 6: Return the result of converting fahrenheit to celcius.
            Console.WriteLine("Assignment 6: Return the result of converting fahrenheit to celcius.");
            Console.WriteLine("ConvertFahreheitToCelcius(1) = " + Calculator.ConvertFahreheitToCelcius(1));
        }
    }
}