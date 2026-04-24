using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int favNumSquared = SquareNumber(favNum);
        int birthYear;
        PromptUserBirthYear(out birthYear);
        DisplayResult(userName, favNumSquared, birthYear);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userFavNum = int.Parse(Console.ReadLine());
        return userFavNum;
    }
    static void PromptUserBirthYear(out int BirthYear)
    {
        Console.WriteLine("Please enter your birth year.");
        BirthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return (int) Math.Pow(number, 2);
    }
    static void DisplayResult(string userName, int numSquared, int birthYear)
    {
        int turningYear = ((DateTime.Now.Year) - birthYear);
        Console.WriteLine($"{userName}, the square of your number is {numSquared}.");
        Console.WriteLine($"{userName}, you will turn {turningYear} this year.");
    }
}