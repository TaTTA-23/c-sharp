using System;

public class Moeda
{
    public static void Main(string[] args)
    {
      Random coin = new Random();
      Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
    }
}
