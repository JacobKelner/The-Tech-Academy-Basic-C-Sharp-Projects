using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());//allows for user inputed string to be converted to integer and stored inside 'weight'
            if (weight > 50)//if user inputted weight is greater than 50, do below code
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");//Displays if weight is greater than 50, program ends
                Console.ReadLine();
            }
            else//below code executes if above 'if' statement doesnt
            {
                Console.WriteLine("Please enter package width: ");
                int width = Convert.ToInt32(Console.ReadLine());//allows for user inputed string to be converted to integer and stored inside 'width'
                Console.WriteLine("Please enter package height: ");
                int height = Convert.ToInt32(Console.ReadLine());//allows for user inputed string to be converted to integer and stored inside 'height'
                Console.WriteLine("Please enter package length: ");
                int length = Convert.ToInt32(Console.ReadLine());//allows for user inputed string to be converted to integer and stored inside 'length'
                int total = width + height + length;//creates total dimensions of weight plus height plus length
                if (total > 50)//bewlow code executes if 'total' is greater than 50
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else//below code executes if 'if' statement doesn't
                {
                    Console.WriteLine("Calculating your estimated shipping cost...");
                    int quote = height * width * length * weight;//multiplies height, width, length and weight variables
                    int finalQuote = quote / 100;//divides 'quote' variable by 100 to get total shipping cost
                    Console.WriteLine("Your estimated total for shipping this package is: $" + finalQuote + " Thank you!");//displays string along with 'finalQuote' variable concatenated inside of string
                    Console.ReadLine();//allows for console to be displayed
                }
             
            }           
        }
    }
}
