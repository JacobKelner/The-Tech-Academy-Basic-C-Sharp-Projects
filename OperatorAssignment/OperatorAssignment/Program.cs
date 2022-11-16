using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();//instantiate Employee object 'employee1'
            employee1.Id = "1";//sets value of Id property to 1
            employee1.FirstName = "James";//sets value of FirstName property to 'James'
            employee1.LastName = "Holiday";//sets value of Last Name property to 'Holiday'

            Employee employee2 = new Employee();//instantiates Employee object 'employee2'
            employee2.Id = "2";//sets value of employee1.Id property to 2
            employee2.FirstName = "James";//sets value of FirstName property to 'James'
            employee2.LastName = "Simmons";//sets value of LastName property to 'Simmons'

            Console.WriteLine(employee1 == employee2);//display to console bool value of 'is employee1 equal to employee2?'
            Console.WriteLine(employee1 != employee2);//display to console bool value of 'is employee1 not equal to employee2?'

            Console.ReadLine();//ensures console remains open


        }
    }
}
