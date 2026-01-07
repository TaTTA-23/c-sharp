//Random random = new Random();: Cria uma instância da classe Random, que é usada para gerar números aleatórios.
//current = random.Next(1, 11);: Chama o método Next da instância random para gerar um número inteiro aleatório entre 1 (inclusive) e 11 (exclusive).
// o código irá gerar números aleatórios entre 1 e 10 e imprimir cada número até o número 7 seja gerado.
using System;

public class Aleatorio

{
    public static void Main(string[] args)
    {
    Random random = new Random();
    int current = 0;
    
    do
    {
        current = random.Next(1, 11);
        Console.WriteLine (current);
        
    } while (current != 7);
  }
}
