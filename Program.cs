using System;
using Sphynx.Models;

namespace Sphynx
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Riddle me this: What is always old and sometimes new; never sad, sometimes blue; never empty, but sometimes full; never pushes, always pulls?");
      Console.WriteLine("Please enter your answer");
      string userAnswer = Console.ReadLine();
      if (userAnswer == "moon" || userAnswer == "Moon" || userAnswer == "MOON")
      {
        Console.WriteLine("Correct! Try another riddle?");
        Console.WriteLine("Please type (yes) to go to the next riddle or type (no) to complete the Sphynx challenge:");
        string userAnswerTwo = Console.ReadLine();
        if (userAnswerTwo == "yes" || userAnswerTwo == "Yes" || userAnswerTwo == "YES")
        {
          RiddleTwo();
        }
        else
        {
          Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
          Console.WriteLine("Congratulations!! You have defeated the Sphynx!!");
          Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        }

      }
      else
      {
        Console.WriteLine("Sphynx has decided to eat you");
      }
    }

    static void RiddleTwo()
    {
      Console.WriteLine("Riddle me this: What has one voice but goes on four legs in the morning, two in the afternoon, and three in the evening?");
      Console.WriteLine("Please enter your answer");
      string userAnswer = Console.ReadLine();
      if (userAnswer == "Human" || userAnswer == "human" || userAnswer == "HUMAN")
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine("Congratulations!! You have defeated the Sphynx!!");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      }


      else
      {
        Console.WriteLine("Sphynx has decided to eat you");
      }
    }

  }

}