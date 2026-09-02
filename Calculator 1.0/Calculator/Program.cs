using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            // amount of values
            Console.WriteLine($"Hello, how many values does your calculation contain?");
            Console.WriteLine("(No more than 3 values)");
            string Value = Console.ReadLine();
            int.TryParse(Value, out int count);
            if (string.IsNullOrEmpty(Value) || (count > 3) || (count < 2))
            {
                Console.WriteLine("Invalid input, please enter a number between 2 and 3.");
                Console.Clear();
                Main(args);
            }
            Console.Clear();

            // first value
            Console.WriteLine("Enter your first value.");
            var value1 = Console.ReadLine();
            int.TryParse(value1, out int number1);
            if (string.IsNullOrEmpty(value1))
            {
                Console.WriteLine("Invalid input");
                Console.Clear();
                Main(args);
            }
            Console.Clear();

            // calculation for 2 values
            if (Value == "2")
            {
                // calculation method
                Console.WriteLine("What kind of calculation method do you want to execute?");
                Console.WriteLine("+, -, *, /");
                List<char> methode = new List<char>() { '+', '-', '*', '/' };
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input");
                    Console.Clear();
                    Main(args);
                }
                Console.Clear();

                // second value
                Console.WriteLine("Enter your second value.");
                var value2 = Console.ReadLine();
                int.TryParse(value2, out int number2);
                if (string.IsNullOrEmpty(value2))
                {
                    Console.WriteLine("Invalid input");
                    Console.Clear();
                    Main(args);
                }
                Console.Clear();

                // Execute the calculation
                if (input == "+")
                {
                    Console.WriteLine($"Your result is: {number1 + number2}");
                }
                if (input == "-")
                {
                    Console.WriteLine($"Your result is: {number1 - number2}");
                }
                if (input == "*")
                {
                    Console.WriteLine($"Your result is: {number1 * number2}");
                }
                if (input == "/")
                {
                    Console.WriteLine($"Your result is: {number1 / number2}");
                }

            }

            // calculation for 3 values
            if (Value == "3")
            {
                // first calculation method
                Console.WriteLine("What is your first Calculation methode?");
                Console.WriteLine("+, -, *, /");
                string methode1 = Console.ReadLine();
                int.TryParse(methode1, out int m1);
                Console.Clear();

                // second value
                Console.WriteLine("Enter your second value.");
                var value2 = Console.ReadLine();
                int.TryParse(value2, out int number2);
                if (string.IsNullOrEmpty(value2))
                {
                    Console.WriteLine("Invalid input");
                    Console.Clear();
                    Main(args);
                }
                Console.Clear();

                // second calculation method
                Console.WriteLine("What is your second Calculation methode?");
                Console.WriteLine("+, -, *, /");
                string methode2 = Console.ReadLine();
                int.TryParse(methode2, out int m2);
                Console.Clear();

                // third value
                Console.WriteLine("Enter your third value.");
                var value3 = Console.ReadLine();
                int.TryParse(value3, out int number3);
                if (string.IsNullOrEmpty(value3))
                {
                    Console.WriteLine("Invalid input");
                    Console.Clear();
                    Main(args);
                }
                Console.Clear();

                // execute the calculation
                if (((methode1 == "*") || (methode1 == "/")) && ((methode2 != "*") || (methode2 != "/")))
                {
                    int part1 = number1 + m1 + number2;
                    int result = part1 + m2 + number3;

                    Console.WriteLine($"Your result is: {result}");
                }
                if (((methode2 == "*") || (methode2 == "/")) && ((methode1 != "*") || (methode1 != "/")))
                {
                    int part1 = number2 + m2 + number3;
                    int result = part1 + m1 + number1;

                    Console.WriteLine($"Your result is: {result}");
                }
                else
                {
                    int part1 = number1 + m1 + number2;
                    int result = part1 + m2 + number3;

                    Console.WriteLine($"Your result is: {result}");
                }

            }


            // cycle/end of the program
            Console.WriteLine();
            Console.WriteLine("Do you want to execute another calculation? (Yes/No)");

            if (Console.ReadLine() == "Yes")
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                return;
            }



        }
    }
}