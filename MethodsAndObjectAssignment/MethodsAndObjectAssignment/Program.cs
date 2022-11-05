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
            Employee employee = new Employee();//Instantiate class employee object
            employee.FullNames = new List<string> { "Sample Student" };//Contains strings inside list calling from employee
            employee.SayName();//calling 'SayName()' from employee obbject
            Console.ReadLine();//Ensures console remains open
        }
    }
}
