using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> user_list = new List<int>();
        while (true)
        {
            Console.WriteLine("Enter number: ");
            String user_input = Console.ReadLine();
            int num = int.Parse(user_input);
            if (num == 0)
            {
                break;
            }
            user_list.Add(num);

        }
        List<int> only_positive_num = [.. user_list];
        while (true)
        {
            if (only_positive_num.Min() < 0)
            {
                only_positive_num.Remove(only_positive_num.Min());
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"The sum is: {user_list.Sum()}");
        Console.WriteLine($"The largest number is: {user_list.Max()}");
        Console.WriteLine($"The smallest positive number is: {only_positive_num.Min()}");
        Console.WriteLine($"The average is: {user_list.Average()}");
        List<int> user_list_sorted = new List<int>();
        user_list_sorted = user_list.OrderBy(n => n).ToList();
        Console.WriteLine($"The sorted list is: {string.Join(", ", user_list_sorted)}");
        
    }
}