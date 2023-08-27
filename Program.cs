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
      if (userAnswer == "moon")
      {
        Console.WriteLine("Correct!");
      }
      else
      {
        Console.WriteLine("Sphynx has decided to eat you");
      }
    }

  }
}