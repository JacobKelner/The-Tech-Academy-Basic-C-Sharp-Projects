using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Integer
    {
        public void Class1(int data)//method with integer parameter
        {
            int result = data / 2;//declares int variable 'result' to equal data divided by 2
            Console.WriteLine(result);//display result to screen
            //Console.ReadLine();//ensures console remains open
        }
        public void Class1(int data, int howManyTimes)//overloaded method with different parameters
        {
            for (int i = 0; i < howManyTimes; i++)//for loop 
            {
                int result = data / 2;//declares int variable 'result' to equal data divided by 2
                Console.WriteLine(result);//displays variable 'result'
                //Console.ReadLine(); //ensures console remains open
            }
        }
        public void Class1(out int data)
        {
            data = 60;
            //Console.ReadLine();
        }
    }
}
