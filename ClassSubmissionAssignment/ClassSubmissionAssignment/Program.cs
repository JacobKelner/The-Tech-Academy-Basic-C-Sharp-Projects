using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    static class Program//class declared static
    {
        static void Main(string[] args)
        {
            Integer obj1 = new Integer();//instantiated class
            Console.WriteLine("Please input a number: ");//displays message to user
            int user = Convert.ToInt32(Console.ReadLine());//converts user input to integer and saves to integer variable 'user'
            obj1.Class1(user);//calls class along with method taking in variable 'user'
            obj1.Class1(user, 3);//calls class along with method taking in vaiable 'user', explicitly passing in the value 3
            Console.ReadLine();
        }
    }
}
