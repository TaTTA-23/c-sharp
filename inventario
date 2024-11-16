/*

A empresa precisa que você faça um inventário do depósito para determinar o número de produtos que estão prontos para envio. 
Além do número total de produtos prontos, é necessário relatar o número de produtos prontos armazenados em cada compartimento individual do depósito e o total acumulado.
Esse total acumulado será usado para criar uma trilha de auditoria a fim de verificar novamente o trabalho e identificar qualquer "redução".
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Criando uma instância da classe InventoryOrder
        InventoryOrder inventoryOrder = new InventoryOrder();
        
       /* // Exibindo os itens do inventário
        inventoryOrder.DisplayInventory();
        */
    }
}

public class InventoryOrder
{
    // Declaração do array (campo da classe)
    int[] inventoryOrder;
    int sum = 0;
    int bin = 0;
    // Construtor da classe
    public InventoryOrder()
    {
        // Inicialização do array dentro do construtor
        inventoryOrder = new int[] { 200, 450, 700, 175, 250 };

        // Exibindo os itens dentro do construtor
        Console.WriteLine("Itens no inventário inicial:");
        
        foreach (int item in inventoryOrder)
        {
            sum += item;
            bin++;
            Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum}).");
        }
        {
            Console.WriteLine($"We have {sum} items in inventory.");
        }
    }

    /*// Método para exibir os itens do inventário
    public void DisplayInventory()
    {
        Console.WriteLine("\nItens no inventário (via DisplayInventory):");
        foreach (int item in inventoryOrder)
        {
            Console.WriteLine(item);
        }
        */
    }

