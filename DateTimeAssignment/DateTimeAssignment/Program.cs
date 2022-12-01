using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DateTime AddHours(double value);
            DateTime dt1 = DateTime.Now; //establishes the current datetime to variable 'dt1'
            Console.WriteLine(dt1);//prints 'dt1' which is the current date and time
            Console.WriteLine("Please input a number: ");//displays string to console
            double userNumber = Convert.ToDouble(Console.ReadLine());//saves user input under 'userNumber', and converts it to a double data type
            DateTime dt2 = dt1.AddHours(userNumber);//establishes a datetime class 'dt2', which equals the current date and time 'dt1' plus 'userNumber' hours
            Console.WriteLine("This is what the time will be in " + Convert.ToDouble(userNumber) + " hours.");//displays message stating that below is what the time will be in 'userNumber' hours
            Console.WriteLine(dt2);//displays 'dt2', which again, is current date and time plus 'userNumber' hours
            Console.ReadLine();//ensures console remains open
        }
    }
}
