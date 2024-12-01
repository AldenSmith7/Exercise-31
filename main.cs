using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine("Enter your message:");
    string message = Console.ReadLine();

    int length = message.Length;

    if (length > 140)
    {
        Console.WriteLine("Rejected.");
    }
    else
    {
        Console.WriteLine("Posted.");
    }
  }
}