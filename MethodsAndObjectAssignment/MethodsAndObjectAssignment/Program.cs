using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FullNames = new List<string> { "Sample", "Student" };
            //Employee.SayName();
            Console.ReadLine();
            
        }
    }
}
