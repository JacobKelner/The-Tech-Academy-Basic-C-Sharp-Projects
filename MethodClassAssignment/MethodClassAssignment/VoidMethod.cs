using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class VoidMethod
    {
        public void Class(int data, int data2)//public void method taking in two integers as parameters
        {
            int result = data + 2;//'result' equals data + 2 (operation on first integer)
            Console.WriteLine(data2);//displays second integer to screen
            Console.ReadLine();//ensures console remains open
        }
    }
}
