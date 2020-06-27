using System;

namespace GuessingGame
{
    class Program
    {
         static void Main(string[] args)
         {
             Random rand = new Random();
             int start = 0;
             int end = 100;
             int magicNumber = rand.Next(start, end+1);
             int guess = -1;
             Console.WriteLine($"Guess a number between {start} and {end}\nGood Luck!");
             while (guess != magicNumber)
             {
                 try
                 {
                      guess = Convert.ToInt16(Console.ReadLine());
                      Console.WriteLine(
                          guess > magicNumber ? "Too Large!" : (guess < magicNumber ? "Too small!" : "YOU WON MADAFAKA")
                          );
                 }
                 catch (Exception e)
                 {
                     Console.WriteLine("Wrong input!");
                 }
             }

         }

       
    }
}