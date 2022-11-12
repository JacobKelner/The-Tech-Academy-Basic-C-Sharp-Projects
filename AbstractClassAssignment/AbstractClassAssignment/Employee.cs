using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee : Person, IQuittable//class Employee is inheriting Person class, alos inherits interface 'IQuittable'
    {
        public override void SayName()//creates SayName() method, override required for inherited abstract class
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);//displays message, along with properties created in Person, and defined in Program
            Console.ReadLine();//ensures console remains open
        }
        public void Quit()//void method 'Quit()'
        {
            Console.WriteLine("Goodbye");//Displays to console
            Console.ReadLine();//Ensures console remains open
        }


        
        
    }
}
