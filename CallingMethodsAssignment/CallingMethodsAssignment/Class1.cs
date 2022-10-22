using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
   public class Class1
    {
      public int Add(int data)//method named 'Add' is public, takes in int parameter and passes in the integer data
        {
            data = data + 7;//data is equal to user input + 7
            return data;//returns 'data'
        }

        public int Divide(int data2)//method name 'Divide' is public, while also passing in 'data2'
        {
            data2 = data2 - 2;//data2 is equal to the userinput minus 2
            return data2;//returns 'data2'
        }
        
        public int Multiply(int data3)//method name 'Multiply' is public, while passing in 'data3'
        {
            data3 = data3 * 4;//returns 'data3', which is the users input and multiplies it by 4
            return data3;
        }
       
    }
}
