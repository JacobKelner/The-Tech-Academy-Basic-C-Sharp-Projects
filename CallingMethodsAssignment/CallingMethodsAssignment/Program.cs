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
        public static int Data2 { get; set; }
        public static int Data3 { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            string line = Console.ReadLine();//user input saved into variable 'line'
            Data = Int32.Parse(line);//converts 'line' to int and saves under 'Data'
            Data2 = Int32.Parse(line);//converts 'line' to int and saves under 'Data2'
            Data3 = Int32.Parse(line);//converts 'line' to int and saves under 'Data3'
            var operatorObject = new Class1();//variable is equal to new Class1();
            var result = operatorObject.Add(Data);//result variable is equal to Class1, saved under operatorObject, and adding variable data
            var result2 = operatorObject.Divide(Data2);//result2 variable is equal to Class1, saved under operatorObject, and adding variable data2
            var result3 = operatorObject.Multiply(Data3);//result3 variable is equal to Class1, saved under operatorObject, and adding variable data3
            Console.WriteLine(result);//display varaible result
            Console.WriteLine(result2);//display variable result2
            Console.WriteLine(result3);//display variable result3
            Console.ReadLine();//ensures console remains open

          
        }
    }
}
