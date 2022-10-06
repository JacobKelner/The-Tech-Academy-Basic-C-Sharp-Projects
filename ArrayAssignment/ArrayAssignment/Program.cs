using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string[] stringArray = new string[] { "LeBron", "Kevin", "Damian", "Luka", "Giannis", "Stephen" };//creates array of strings and holds values inside variable 'stringArray'

        Console.WriteLine("Please input an index (0 - 5) to display a preset name in our Array.");//instructions for user
        int input = Convert.ToInt32(Console.ReadLine());//allows for user input and stores inside integer variable 'input'
        
        if (input > 5)//if loop to ensure user selects correct a correct index number, from 0-5
        {
            Console.WriteLine("This is not a valid number. Please input a number ranging from 0 to 5.");//tells user input was incorrect, and to try again
            input = Convert.ToInt32(Console.ReadLine());//stores user input inside variable 'input'
            Console.WriteLine(stringArray[input]);//displays a string from array based on user input that was stored inside variable 'input'
            Console.ReadLine();//allows for hte console to remain open
        }
        else//executes if 'if' loop is not executed
        {
            Console.WriteLine(stringArray[input]);//display a string from array based on user input that was stored inside variable 'input'
            Console.ReadLine();
        }
        

        int[] numArray = new int[] { 0, 7, 24, 23, 99, 52, 89, 2468, 4726, 17510 };//creates array of integers and holds values inside variable 'numArray'

        Console.WriteLine("Please input an index (0 - 9) to display a preset number in our Array.");//directions for user
        int answer = Convert.ToInt32(Console.ReadLine());//allows for user input and stores inside integer variable 'answer'

        if (answer > 9)//if loop to ensure user selects correct index number, from 0-9
        {
            Console.WriteLine("This is not a valid index. Please input a number ranging from 0 - 9");//tells user input was incorrect and to try again
            answer = Convert.ToInt32(Console.ReadLine());//stores user input inside variable 'answer'
            Console.WriteLine(numArray[answer]);//displays a string from array based on user input that was stored inside variable 'answer'
            Console.ReadLine();
        }
        else//executes if 'if' loop is not executed
        {
            Console.WriteLine(numArray[answer]);//displays a string from array based on user input that was stored inside variable 'answer'
            Console.ReadLine();
        }

        List<string> intList = new List<string>();//creates a list of strings and holds value inside 'intList'
        intList.Add("Anfernee");//adds string to list
        intList.Add("Jordan");//adds string to list
        intList.Add("Tyler");//adds string to list
        intList.Add("Christian");//adds string to list
        intList.Add("Nassir");//adds string to list
        Console.WriteLine("Please input an index (0 - 4) to display a preset name in our list");//instructions for user
        int listAnswer = Convert.ToInt32(Console.ReadLine());//allows for user input and stores input inside integer variable 'listAnswer'

        if (listAnswer > 4) //if loop to ensure user selects a correct index number, ranging from 0-4
        {
            Console.WriteLine("This is not a valid index. Please try again, inputting an index ranging from 0 - 4.");//tells user their input was incorrect and to try again
            listAnswer = Convert.ToInt32(Console.ReadLine());//stores user input inside variable 'listAnswer'
            Console.WriteLine(intList[listAnswer]);//displays a string from list based on user input that was stored inside variable 'listAnswer'
            Console.ReadLine();
        }
        else//executes if 'if' loop was not executed
        {
            Console.WriteLine(intList[listAnswer]);//displays a string from list based on user input that was stored inside variable 'listAnswer'
            Console.ReadLine();//ensures console remains open
        }
    }
}

