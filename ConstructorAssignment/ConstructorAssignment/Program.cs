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
            Foo Ford = new Foo();//creates object called Ford from Foo class, this will call the constructor

            Console.WriteLine("Ford started developing the " + Ford.model + " in the year " + Ford.year + ".");//Ford.model and Ford.year are being defined from the properties in Class1.cs
            Console.ReadLine();


        }
    }
}
