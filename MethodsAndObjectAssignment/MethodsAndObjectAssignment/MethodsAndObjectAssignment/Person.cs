using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectAssignment
{
    public class Person
    {
        public string FirstName { get; set; }//Property string FirstName
        public string LastName { get; set; }//Property string LastName
        
        public void SayName()//Void method SayName taking in no parameters
        {   
            Console.WriteLine("Name: " + FirstName + " " + LastName);//display properties, which are defined in Program
        }
    }
}
