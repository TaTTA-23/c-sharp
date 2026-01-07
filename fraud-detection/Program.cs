/* 
Desafio de codificação – Reportar as IDs de pedido que precisam de uma 
investigação mais aprofundada.
Pedidos que começam com a letra "B" têm uma taxa de incidência de fraude 25 vezes maior que o normal. 
Você escreverá um novo código para imprimir na saída a ID de novos pedidos que comecem com a letra "B". 
Isso será usado pela nossa equipe anti-fraude para investigar mais a fundo.

*/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Criando uma instância da classe FraudulentOrderIDs
        FraudulentOrderIDs fraudulentOrder = new FraudulentOrderIDs();
        //Exibindo os IDs fraudulentos que começam com 'B'
        fraudulentOrder.DisplayItemsStartingWithB();
    }
}

 public  class FraudulentOrderIDs
{
    //Declaraçao do array
    string[]  fraudulentOrderIDs;
    
    // Construtor da classe
    public  FraudulentOrderIDs()
    {
        //Inicialização do array dentro do construtor
        fraudulentOrderIDs = new string[]  {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
        
        }
        //Método para exibir todos os IDs fraudulentos 'B'
        public void DisplayItemsStartingWithB()
        {
            //Exibe todos os IDs do array
            Console.WriteLine("\nItens no inventário que começam com 'B': ");
            foreach (string item in fraudulentOrderIDs)
            
            {
                //verifica se o item começa com 'B' (não diferencia maiúscula de minúscula)
                if (item.StartsWith("B", StringComparison.OrdinalIgnoreCase))
            
        {
            
            Console.WriteLine(item);
            }
        }
    }
}

