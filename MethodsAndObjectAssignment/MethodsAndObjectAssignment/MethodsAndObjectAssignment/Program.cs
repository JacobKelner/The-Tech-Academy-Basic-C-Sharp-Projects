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
            employee.FirstName = "Sample";//gives FirstName a string value, calling from employee
            employee.LastName = "Student";//gives LastName a string value, calling from employee
            employee.SayName();//calling 'SayName()' from employee obbject
            Console.ReadLine();//Ensures console remains open
        }
    }
}
