using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");//Console.WriteLine displays text inside ()
            Console.WriteLine("Student Daily Report");//Console.WriteLine displays text inside ()
            

            Console.WriteLine("What is your name?: ");
            string yourname = Console.ReadLine();//allows for user to input string value and is saved inside string variable 'yourname'

            Console.WriteLine("What course are you on?: ");
            string coursename = Console.ReadLine();//allows for user to input string value and is saved inside string variable 'coursename'

            Console.WriteLine("What page number?: ");
            string pagenumber = Console.ReadLine();//creates string variable that holds value of user input 
            int pagenum = Convert.ToInt32(pagenumber);//converts string variable into integer value

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\": ");//the escape backslashes allow for double quotes inside of string quotes
            string answer = Console.ReadLine();//allows for user to input string value


            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.: ");
            string response = Console.ReadLine();//allows for user to input string value

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.: ");
            string feedback = Console.ReadLine();//allows for user to input string value

            Console.WriteLine("How many hours did you study today?: ");
            string hours = Console.ReadLine();//creates string variable that holds value of user input 
            int hrs = Convert.ToInt32(hours);//converts string variable into integer value

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");//displays string once all previous questions have been answered

            
            Console.ReadLine();//This is to ensure that to console stays open long enough for the user to read it




        }
    }
}
