using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter your grade percentage. ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);
        
        string letter = "";
        string sign = "";
        
        if (score >= 90)
        {
            letter = "A";
        }
        
        else if (score >= 80)
        {
            letter = "B";
        }

        else if (score >= 70)
        {
            letter = "C";
        }

        else if (score  >= 60)
        {
            letter = "D";
        }
        
        else
        {
            letter = "F";
        }

        int lstDgt = score%10;
        if (lstDgt >= 7)
        {
            sign = "+";
        }

        else if (lstDgt < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }
        
        Console.WriteLine($"{score}--{letter}{sign}");
        
        if (score >= 70)
        {
            Console.WriteLine("Congratulations you passed the test");
        }
        
        else
        {
            Console.WriteLine("much more effort required");
        }
    }
}