using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();//creates object of data type 'Number' 
            Number number2 = number;//assigns data type 'number2' to equal 'number'
            number2.Amount = 23;//sets 'number2.Amount' (amount being the property defined in 'Number.cs') and assigns it a value of 23
            Console.WriteLine(number2.Amount);//Displays number2.Amount to console
            Console.ReadLine();//ensures console remains open 
        }
    }
}
