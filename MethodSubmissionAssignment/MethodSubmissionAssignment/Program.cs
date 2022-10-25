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
            IntegerOperator obj1 = new IntegerOperator();
            Console.WriteLine("Please input two numbers, one at a time: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj1.Obj(num1));
           
            Console.ReadLine();
        }
    }
}
