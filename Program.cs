using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("A number between 1-100.");
        int score = int.Parse(Console.ReadLine());
        if (score >= 100)
        {
            Console.WriteLine("Grade: A+");
            Console.WriteLine("Wow! 100…That’s impressive!");
        }
        else if (score >= 90)
        {
            Console.WriteLine("Grade: A");
            Console.WriteLine("Very nice!");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade: B");
            Console.WriteLine("Keep it up!");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade: C");
            Console.WriteLine("You got this, keep working!");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Grade: D");
            Console.WriteLine("Keep trying!");
        }
        else
        {
            Console.WriteLine("Grade: E");
            Console.WriteLine("Don’t give up!");
        }
    }
}