using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
   public class Class1
    {
      public double Add(int data)//method named 'Add' is public. Double is able to define variables holding numbers with deicmal points. Passes in the integer data
        {
            data = data + 7;//data is equal to user input + 7
            return Divide(data);//return to divide method 
        }

        public double Divide(double data)//method name 'Divide' is public, while also passing in 'data'
        {
            data = data - 2;//data is equal to the passed in data minus 2
            return Multiply(data);//return to multiply method
        }
        
        public double Multiply(double data)//method name 'Multiply' is public, while passing in 'data'
        {
            return data * 4;//returns 'data' times 4
        }
       
    }
}
