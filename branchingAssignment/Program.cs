using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the initial welcome message.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight.
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the weight exceeds the allowed limit.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program if the package is too heavy.
            }

            // Prompt the user for the package dimensions.
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if the total dimensions exceed the allowed limit.
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program if the package is too big.
            }

            // Calculate the shipping quote.
            double dimensionsProduct = width * height * length; // Calculate the volume.
            double quote = (dimensionsProduct * weight) / 100; // Apply the formula.

            // Display the shipping quote.
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
