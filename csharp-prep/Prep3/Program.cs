using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        bool done = true;
        while (done)
        {
            Console.WriteLine("Guess the random number!");
            Random ran = new Random();
            int random_num = ran.Next(1, 101);
            while (true)
            {
                String user_guess = Console.ReadLine();
                int user_guess_num = int.Parse(user_guess);
                if (random_num == user_guess_num)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("Would you like to continue? (y/n)");
                    String user_continue = Console.ReadLine();
                    if (user_continue == "y")
                    {
                        break;
                    }
                    else
                    {
                        done = false;
                        break;
                    } 
                }
                else if (random_num > user_guess_num)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }

        }
    }
}