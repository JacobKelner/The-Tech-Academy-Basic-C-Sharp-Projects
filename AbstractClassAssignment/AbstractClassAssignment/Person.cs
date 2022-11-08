using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    abstract class Person
    {
        public string firstName { get; set; }//public string property called 'firstName'
        public string lastName { get; set; }//public string property called 'lastName'

        public abstract void SayName();//gives abstract 'SayName()' method
    }
}
