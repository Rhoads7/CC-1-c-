using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      // asks for age 
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}
