using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage?");
        String user_value = Console.ReadLine();
        int gradenum = int.Parse(user_value);
        if (gradenum >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (90 > gradenum && gradenum >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (80 > gradenum && gradenum >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (70 > gradenum && gradenum >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
    }
}