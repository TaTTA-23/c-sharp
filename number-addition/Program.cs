
using System;

public class Number
{
    public static void Main()
    {
       // Adição de dois números
       
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// Misturar tipos de dados para forçar as conversões de tipo implícitas

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// Adicionar parênteses para esclarecer sua intenção ao compilador
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// Escrever o código para realizar a adição, subtração, multiplicação e divisão com inteiros
int sum = 7 + 5; 
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// Adicionar o código para realizar uma divisão usando dados decimais literais
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
}
}
