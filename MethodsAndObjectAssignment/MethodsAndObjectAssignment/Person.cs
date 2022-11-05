using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectAssignment
{
    public class Person
    {
        public List<string> FullNames { get; set; }//Creates list called FullNames
        public string FirstName { get; set; }//Property string FirstName
        public string LastName { get; set; }//Property string LastName
        
        public void SayName()//Void method SayName taking in no parameters
        {
            foreach (string names in FullNames)//foreach names in FullNames
            {
                Console.WriteLine("Name: " + names);//display names
            }
        }
    }
}
