// usando a instrução continue para passar diretamente para a expressão booliana

using System;

public class Aleatorio

{
    public static void Main(string[] args)
   { 

    Random random = new Random();
    int current = random.Next(1, 11);
    
    do
    {
    current = random.Next(1, 11);
    
    if (current >= 8) continue;
    
    Console.WriteLine(current);
    } while (current != 7);
  }
}
