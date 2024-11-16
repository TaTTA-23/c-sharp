/* 
1. Escolher nomes descritivos para as variáveis que descrevam a finalidade e a intenção delas.

2. usar comentários de código para instruir temporariamente o compilador a ignorar linhas de código;

3. usar comentários de código para descrever uma finalidade ou requisitos de nível superior para uma passagem de código;

4. escrever código que use espaço em branco de modo eficaz para transmitir a relação de linhas de código.
observaçao:  este é um comentário em bloco */

using System;

public class Program
{
    public static void Main(string[] args)
   /* {
       string firstName = "Bob";
       int widgetsPurchased = 7;
       //Testing a change to the message.
       //int widgetSold = 7;
       //Console.WriteLine($"{firstName} sold {widgetSold} widgets.");
       Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
    }*/

/*
comentário de alto nível: explicando a finalidade do código.
O código a seguir cria cinco OrderIDs aleatórios
  para testar o processo de detecção de fraude.  IDs do pedido 
  consistem em uma letra de A a E e três
  número de dígito. Ex. A123.
*/

    {
        Random random = new Random();
        string[] orderIDs = new string[5];
    
        for (int i = 0; i < orderIDs.Length; i++)
        {
            
            int prefixValue = random.Next(65, 70);
             
            string prefix = Convert.ToChar(prefixValue).ToString();
            
            string suffix = random.Next(1, 100).ToString("000");
            
            orderIDs[i] = prefix + suffix;
        }
        foreach (var orderID in orderIDs)
        {
             Console.WriteLine(orderID);
        }
    }
}

}


