using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try//try block executes code below, and checks for errors not compatible via user input
            {


                List<int> listOfInts = new List<int>()//creates list of integers
            {
                0, 3, 7, 12, 23, 24, 35, 99
            };
                Console.WriteLine("Please enter a number in, which will be divided by each number in our list!");
                int input = Convert.ToInt32(Console.ReadLine());//saves user input inside integer variable, also converted from string to integer
                foreach (int x in listOfInts)//foreach item inside the list...
                {
                    Console.WriteLine(x + " divided by " + input + " equals " + x / input);//display item + string + user input + string + equation of item in list divided by user input
                }
            }
            catch (FormatException ex)//executes if formatexception occurs, possibly user inputted a string, symbol, etc.
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)//executes if user attempts to divide by zero
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            catch (Exception ex)//executes if any exception not defined previously occurs
            {
                Console.WriteLine(ex.Message);//displays error message in console
            }
            finally//always executes
            {
                Console.ReadLine();
            }
            Console.WriteLine("Emerged from catch block and continuing on with execution");
            Console.ReadLine();
        }
    }
}
