using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int faveNum = PromptUserNumber();
        int sqauredNumber = (SquareNumber(faveNum));
        DisplayResult(sqauredNumber,name);
        //code for the functioon to welcome the user to the program
        void DisplayMessage()
        {
            Console.WriteLine("Welcome to the programme.");
        }
        //code for the function to get the user name and return it as a string.
        string PromptUserName()
        {
            Console.Write("what is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        // code for the function to get the user number and return it as an integer.
        int PromptUserNumber()
        {
            Console.Write("what is your favorite number? ");
            string favNum = Console.ReadLine();
            int number = int.Parse(favNum);
            return number;
        }
        // code tfor the function that accepts an integer parameter and returns an integer.
        int SquareNumber(int num)
        {
            int sqrNum = num*num;
            return sqrNum;
        }
        // code that accept and displays the users name and sqaured number.
        void DisplayResult(int sqdNum, string userName)
        {
            Console.WriteLine($"Your name is {userName} and your number squared is {sqdNum}");
        }
    }
}