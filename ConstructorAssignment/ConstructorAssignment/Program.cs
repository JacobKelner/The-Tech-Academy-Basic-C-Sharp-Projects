using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string randomFullName = "Bob Ross";//creates const keyword variable. This will not change during the lifetime of the program
            var name = "Leonardo da Vinci";//creates var keyword tp declare implicit variable type
            mySampleClass obj = new mySampleClass();//creates object from mySampleClass
            Console.WriteLine("A list of just a few famous artists are... " + obj._Name + ", " + name + " and " + randomFullName + ".");//displays to console
            Console.ReadLine();//ensures console remains open 

        }
    }
}
