using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //title
            Console.WriteLine("Anonymous Income Comparison Program");

            //defining person 1 variables
            Console.WriteLine("Person 1");
            //asks hours worked per week and hourly rate for person 1
            Console.WriteLine("Hourly Rate?");
            int hrly1 = int.Parse(Console.ReadLine());//allows for user input to determine variable (hourly pay) value
            Console.WriteLine("Hours worked per week?");
            int hrswrk1 = int.Parse(Console.ReadLine());//allows for user input to determine variable (hours worked in a week) value
            //value of annual salary of person 1
            int sal1 = hrly1 * hrswrk1 * 52;//creates variable of salary by multiplying hrs worked by pay rate by 52 weeks in a year

            //defining person 2 variables
            Console.WriteLine("Person 2");
            //asks hours worked per week and hourly rate for person 2
            Console.WriteLine("Hourly Rate?");
            int hrly2 = int.Parse(Console.ReadLine());//allows for user input to determine variable (hourly pay) value
            Console.WriteLine("Hours worked per week?");
            int hrswrk2 = int.Parse(Console.ReadLine());//allows for user input to determine variable (hours worked in a week) value
            //value of annual salary of person 2 
            int sal2 = hrly2 * hrswrk2 * 52;//creates variable of salary by multiplying hrs worked by pay rate by 52 weeks in a year

            //display annual salary variable of person 1 
            Console.WriteLine("Annual salary of Person 1: " + sal1);

            //display annual salary variable of person 2 
            Console.WriteLine("Annual salary of Person 2: " + sal2);

            //ask if person one makes more than person 2, and 
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            //creates bool variable, asking if sal1 is more than sal2, reflecting the question above
            bool more = sal1 > sal2;
            Console.WriteLine(more);//displays boolean value which is now placed inside of variable, true or false
            


            Console.ReadLine();//allows for console to remain open

        }
    }
}
