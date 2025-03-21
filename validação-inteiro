/*
Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.

Dentro do bloco de iteração:

A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
A solução deve garantir que a entrada seja uma representação válida de um inteiro.
Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.
Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.

*/
using System;

public class EntradaValidada
{
    public static void Main(string[] args)
    {
        int valor;
        bool entradaValida = false;

        Console.WriteLine("Digite um valor inteiro entre 5 e 10:");

        do
        {
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out valor))
            {
                if (valor >= 5 && valor <= 10)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Valor fora do intervalo. Digite um valor inteiro entre 5 e 10:");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um valor inteiro válido:");
            }

        } while (!entradaValida);

        Console.WriteLine($"Valor {valor} aceito!");
    }
}
