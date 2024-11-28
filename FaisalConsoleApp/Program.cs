using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaisalConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine()); // Convert the user's input to a double value

            // Check if the weight exceeds the maximum allowed weight
            if (weight > 50)
            {
                // If the weight is greater than 50, display an error message and end the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Prompt the user for the package width
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine()); // Convert the user's input to a double value

            // Prompt the user for the package height
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine()); // Convert the user's input to a double value

            // Prompt the user for the package length
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine()); // Convert the user's input to a double value

            // Check if the sum of the dimensions exceeds the maximum allowed size
            if (width + height + length > 50)
            {
                // If the total dimensions are greater than 50, display an error message and end the program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Multiply the three dimensions (width, height, and length) together
            double volume = width * height * length;

            // Multiply the product of the dimensions by the weight
            double totalCost = volume * weight;

            // Divide the total by 100 to get the shipping quote
            double quote = totalCost / 100;

            // Display the calculated shipping quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // Thank the user for using the service
            Console.WriteLine("Thank you!");
        }
    }
}
