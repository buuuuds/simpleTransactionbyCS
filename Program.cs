using System;

namespace MyProgram2
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            // Enter the pieces of apple:
            // Enter the price of each apple:

            // Total Price:     (with decimal)
            // Enter your cash:
            // Change:          (with decimal)

            Console.Write("Enter the pieces of apple: ");
            int pieces = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of each apple: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            decimal totalPrice = pieces * price;
            Console.WriteLine($"Total Price: Php {totalPrice:F2}");

            Console.WriteLine();

            decimal cash;

            // Ask until cash is enough
            while (true)
            {
                Console.Write("Enter your cash: Php ");
                cash = Convert.ToDecimal(Console.ReadLine());

                if (cash < totalPrice)
                {
                    Console.WriteLine("Insufficient cash. Please enter an exact price or higher than the total price.");
                }
                else
                {
                    break;
                }
            }

            decimal change = cash - totalPrice;
            Console.WriteLine($"Change Amount: Php {change:F2}");
            Console.WriteLine("Thank You, Buy Again!");
        }
    }
}

