using System;

namespace NumberGuessing
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter a password: ");
      string passWord = Console.ReadLine();
      Console.WriteLine("Remember this: " + passWord);
      Console.WriteLine();
      Console.WriteLine("What was the password?");
      Console.Write("Enter here: ");
      string remBer = Console.ReadLine();
      if (remBer == passWord)
      {
        Console.WriteLine("Correct password.");
        Console.WriteLine("Press any key to finish.");
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("Incorrect password.");
        Console.WriteLine("Press any key to finish.");
        Console.ReadLine();
      }

    }
  }
}
