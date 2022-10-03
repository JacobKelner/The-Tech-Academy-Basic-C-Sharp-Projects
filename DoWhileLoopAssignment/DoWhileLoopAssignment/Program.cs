using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number?");
            int num = Convert.ToInt32(Console.ReadLine());//variable 'num' is converted to integer value and takes value based on user input. This correlates with case #
            bool isGuessed = num == 3;//sets boolean variable for user input 'num'
            do//do while loop
            {
                switch (num)//switch statement
                {
                    case 3:
                        Console.WriteLine("You guessed 3. You are correct.");//executes line when case number is inputted
                        isGuessed = true;//sets boolean variable to true on this statement 
                        break;//break makes sure switch statement doesn't continue
                    case 22:
                        Console.WriteLine("You guessed 22. You are wrong. Try again");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());//user input 'num' is converted to integer value
                        break;//break makes sure switch statement doesn't continue
                    case 23:
                        Console.WriteLine("23 is not right. Try again");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());//user input 'num' is converted to integer value
                        break;//break makes sure switch statement doesn't continue
                    case 24:
                        Console.WriteLine("You guessed 24. That's my second favorite number, so please try again.");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());//user input 'num' is converted to integer value
                        break;//break makes sure switch statement doesn't continue
                    default://executes whenever something outside of above cases is inputted
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());//user input 'num' is converted to integer value
                        break;//break makes sure switch statement doesn't continue

                }
            }
            while (!isGuessed);//while isGuessed is equal to false


            Console.WriteLine("Please input a number to see what NBA team correlates with that number, and try to find my favorite team!");
            int team = Convert.ToInt32(Console.ReadLine());//variable 'team' is converted to integer value and takes value based on user input. This correlates with case #
            bool guess = false;//sets boolean variable 'guess' to false

            while (!guess)//while loop, while guess is equal to false
            {
                switch (team)//switch statement
                {
                    case 1:
                        Console.WriteLine("You guessed Team 1, the Golden State Warriors. This is not my favorite team, try again.");//executes line when case number is inputed
                        Console.WriteLine("Please input a number to see what NBA team correlates with that number, and try to find my favorite team!");
                        team = Convert.ToInt32(Console.ReadLine());//user input 'team' is converted to integer value
                        break;//break makes sure switch statement doesn't continue
                    case 2:
                        Console.WriteLine("You guessed Team 2, the Los Angeles Lakers. This is not my favorite team, try again.");
                        Console.WriteLine("Please input a number to see what NBA team correlates with that number, and try to find my favorite team!");
                        team = Convert.ToInt32(Console.ReadLine());//user input 'team' is converted to integer value
                        break;//break makes sure switch statement doesn't continue
                    case 3:
                        Console.WriteLine("You guessed Team 3, the Miami Heat. This is not my favorite team, try again.");
                        Console.WriteLine("Please input a number to see what NBA team correlates with that number, and try to find my favorite team!");
                        team = Convert.ToInt32(Console.ReadLine());//user input 'team' is converted to integer value
                        break;//break makes sure switch statement doesn't continue
                    case 4:
                        Console.WriteLine("You guessed Team 4, the Portland Trail Blazers. This is my favorite team, good job!");
                        guess = true;//sets boolean variable to true
                        break;//break makes sure switch statement doesn't continue
                    default://executes whenever something outside of above cases is inputted
                        Console.WriteLine("There is no team correlating with this number. Try again.");
                        Console.WriteLine("Please input a number to see what NBA team correlates with that number, and try to find my favorite team!");
                        team = Convert.ToInt32(Console.ReadLine());//user input stored inside 'team' is converted to integer value
                        break;//break makes sure switch statement doesn't continue

                }
            }


            Console.ReadLine();//allows for console to remain open
        }
    }
}
