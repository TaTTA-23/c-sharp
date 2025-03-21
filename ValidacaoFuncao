/*A solução deve incluir uma iteração do-while ou while.

Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.

Dentro do bloco de iteração:

A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
A solução deve garantir que o valor inserido corresponda a uma das três opções de função.
Sua solução deve usar o método Trim() no valor de entrada para ignorar caracteres de espaço de entrelinhamento e à direita.
A solução deve usar o método ToLower() no valor de entrada para ignorar maiúsculas e minúsculas.
Se o valor inserido não corresponder a uma das opções de função, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário uma entrada válida.
Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.

*/
using System;

public class ValidacaoFuncao
{
    public static void Main(string[] args)
    {
        string funcao;
        bool funcaoValida = false;

        Console.WriteLine("Digite uma das seguintes funções: Administrador, Gerente ou Usuário.");

        do
        {
            string entrada = Console.ReadLine();
            funcao = entrada.Trim().ToLower(); // Remove espaços e converte para minúsculas

            if (funcao == "administrador" || funcao == "gerente" || funcao == "usuário")
            {
                funcaoValida = true;
            }
            else
            {
                Console.WriteLine("Função inválida. Digite Administrador, Gerente ou Usuário.");
            }

        } while (!funcaoValida);

        Console.WriteLine($"Função '{funcao}' aceita!");
    }
}
