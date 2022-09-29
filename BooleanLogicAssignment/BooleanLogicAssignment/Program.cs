using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");//asks question leading to user input
            int age = int.Parse(Console.ReadLine());//user input gets stored inside 'age' variable
            bool drive = age > 15;//variable 'age' must be greater than 15 in order for 'drive' to be true, otherwise 'drive' is false

            Console.WriteLine("Have you ever had a DUI?");//asks question leading to user input 
            string answer = Console.ReadLine();//user input is stored inside string variable 'answer'(must be true or false)
            bool dui = bool.Parse(answer);//variable 'answer' is converted to boolean variable, assuming user only inputs either true or false

            Console.WriteLine("How many speeding tickets do you have?");//asks question leading to user input
            int speed = int.Parse(Console.ReadLine());//user input (string) gets converted into integer and stored inside integer variable 'speed'
            bool tix = 3 >= speed;//variable 'speed' must hold value equal to 3 or less in order for boolean variable 'tix' to hold true value
            
            Console.WriteLine("Qualified?");
            Console.WriteLine(drive == true && dui == false && tix == true);//boolean variables 'drive' and 'tix' must hold true value, while 'dui' must hold false value in order for the output to be True. Otherwise, qualified automatically becomes false
            Console.ReadLine();//ensures console stays open
            


        }
    }
}
