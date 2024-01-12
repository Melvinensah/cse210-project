using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.Write("kindly guess a number");
        string guess = Console.ReadLine();
        int myGuess = int.Parse(guess);

        
        while(myGuess != magicNumber) 
        {
            Console.Write("what is the magic number? ");
            string userInput = Console.ReadLine();
            myGuess = int.Parse(userInput);
            
            if (myGuess < magicNumber)
            {
                Console.WriteLine("go higher");
                
            }
            else if (myGuess > magicNumber)
            {
                Console.WriteLine("go lower");
            }
       
            else
            {
                    Console.WriteLine("conagratulations your guess is right");
            }
        }
    }
}