using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectAssignment
{
    public class Person
    {
        public List<string> FullNames { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public void SayName()
        {
            foreach (string names in FullNames)
            {
                Console.WriteLine(names);
            }
        }
    }
}
