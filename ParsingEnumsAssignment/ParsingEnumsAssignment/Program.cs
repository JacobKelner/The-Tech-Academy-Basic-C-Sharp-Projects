using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try//try block 
            {
                Console.WriteLine("Please enter the current day of the week: ");//displays message asking user to input the day of the week
                string userInput = Console.ReadLine();//saves user input as string variable 'userInput'
                DaysOfTheWeek.Day day =(DaysOfTheWeek.Day)Enum.Parse(typeof(DaysOfTheWeek.Day), userInput);//creates variable 'day' from 'DaysOfTheWeek.Day' and parses it by defining its type, and what is being parsed, also passing in userInput
                Console.WriteLine("Have a great " + day + "!");//Displays message 
            }
            catch//catch block, executes if above block runs into an error
            {
                Console.WriteLine("Please enter an actual day of the week.");//Displays message
            }
            Console.ReadLine();//Ensures console remains open 
        }
    }
}
