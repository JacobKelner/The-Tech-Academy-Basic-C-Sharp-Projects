using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");//displays message to user
            string userInput = Console.ReadLine();//saves user input as string variable 'userInput'
            Console.WriteLine(userInput);//prints input saved to 'userInput'
            using (StreamWriter file = new StreamWriter(@"C:\Users\15037\Desktop\C#_Challenges\RandomTxtFiles\InputAssignment.txt", true))//using StreamWriter allows for files to be added or overwritten with text, and defines teh file path under variable 'file'
            {
                file.WriteLine(userInput);//writes 'userInput' inside of 'file', which was defined above
            }

            Console.ReadLine();//ensures console remains open 
        }
    }
}
