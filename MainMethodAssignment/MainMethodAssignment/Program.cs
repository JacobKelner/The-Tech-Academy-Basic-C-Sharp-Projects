using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer :");//Displays message to user
            int num1 = Convert.ToInt32(Console.ReadLine());//creates integer variable and converts user input to integer
            MathOperator obj1 = new MathOperator();//creates object to equal new class
            Console.WriteLine(obj1.Add(num1));//Displays obj1 and calls method add taking in num1
            Console.WriteLine("Enter in a decimal: ");//displays message to user 
            decimal num2 = Convert.ToDecimal(Console.ReadLine());//creates decimal variable and converts user input to deicmal 
            Console.WriteLine(obj1.Add(num2));//displays objj and calls method add taking in num2
            Console.WriteLine("Enter a number: ");//displays message to user
            string num3 = Console.ReadLine();// creates string variable and saves user input to it 
            Console.WriteLine(obj1.Add(num3));//displays obj1 and calls method add taking in num3
            Console.ReadLine();//ensures console remains open
        }
    }
}
