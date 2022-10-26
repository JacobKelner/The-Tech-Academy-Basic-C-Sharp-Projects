using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number: ");//displays message
            int num1 = Convert.ToInt32(Console.ReadLine());//converts user input to integer and saves under 'num1'
            IntegerOperator obj1 = new IntegerOperator();//creates object equal to new class
            try//try block
            {
                Console.WriteLine("Please input another number: ");//displays message
                int num2 = Convert.ToInt32(Console.ReadLine());//converts user input to integer and saves under variable 'num2'
                Console.WriteLine(obj1.Obj(num1, num2));//displays obj1 class and calls method Obj taking in both parameters
            }
            catch (Exception ex)//catch block catches all exceptions
            {
                Console.WriteLine(obj1.Obj(num1));//displaus obj1 class and calls method Obj taking in the first parameter
            }
            Console.ReadLine();///ensures console remains open
        }
    }
}
