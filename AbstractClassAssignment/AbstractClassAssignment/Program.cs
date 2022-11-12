using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();//instantiates Employee object
            //employee.firstName = "Sample";//defines property 'firstName' from employee object
            //employee.lastName = "Student";//defines property 'lastName' from employee object
            //employee.SayName();//calls on SayName() method on the object
            IQuittable quit = new Employee();//create object of IQuittable
            quit.Quit();//call object of IQuittable with IQuit() method
        }
    }
}
