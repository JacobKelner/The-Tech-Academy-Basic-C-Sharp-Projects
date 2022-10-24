using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
   public class MathOperator
    {
        public int Add(int data)//public method integer Add taking in integer data
        {
            data = data + 7;//data equals data plus 7 
            return data;//returns data
        }
        public int Add(decimal data2)//public method integer Add taking in decimal data2
        {
            int x = Convert.ToInt32(data2);//creates integer variable and saves data to to it, after its converted to integer 
            int result = x + 2;//creates integer variable named 'result' and has it equal to 'x' + 2
            return result;//returns variable 'result' 
        }
        public int Add(string data3)//public method integer Add taking in string data3
        {
            int y = Convert.ToInt32(data3);//creates integer variable 'y' and converts data3(string) to integer
            int result = y + 3;//creates integer variable 'result' equal to 'y' + 3
            return result;//returns variable 'result'
        }
    }
}
