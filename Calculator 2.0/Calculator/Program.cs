using System;

namespace Taschenrechner
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



        }
    }
}