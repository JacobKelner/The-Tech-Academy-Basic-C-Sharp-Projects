using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        public static int Data { get; set; } //public, returns value of variable name
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            string line = Console.ReadLine();//user input saved into variable 'line'
            Data = Int32.Parse(line);//converts 'line' to int and saves under 'Data'
            var operatorObject = new Class1();//variable is equal to new Class1();
            var result = operatorObject.Add(Data);//result variable is equal to Class1, saved under operatorObject, and adding variable data
            Console.WriteLine(result);//display variable result
            Console.ReadLine();//ensures console remains open

          
        }
    }
}
