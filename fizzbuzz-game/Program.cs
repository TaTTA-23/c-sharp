//Valores de saída de 1 a 100, um número por linha, dentro do bloco de código de uma instrução de iteração.
//Quando o valor atual é divisível por 3, imprima o termo Fizz ao lado do número.
//Quando o valor atual é divisível por 5, imprima o termo Buzz ao lado do número.
//Quando o valor atual é divisível tanto por 3 quanto por 5, imprima o termo FizzBuzz ao lado do número.

using System;

public class Program
{
     public static void Main(string[] args) 
    {
        for (int i = 1; i < 101; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
                 Console.WriteLine($"{i} - FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} - Fizz");
            else if (i % 5 == 0)
                Console.WriteLine($"{i} - Buzz");
            else
            Console.WriteLine($"{i}");
        }
    }
}
