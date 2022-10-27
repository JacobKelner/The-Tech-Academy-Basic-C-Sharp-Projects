using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMethod obj1 = new VoidMethod();//creates object to equal new class
            obj1.Class(2, 7);//calls obj1 in 'Class' while also passing in two numbers
            obj1.Class(data: 2, data2: 7);//calls obj1 in 'Class' while passing in parameters by their name
            
            //Dont need 'Console.ReadLine()' because it is in VoidMethod.cs, which is what is being used to display our parameters, while our parameters are being defined in Program.cs
        }
    }
}
