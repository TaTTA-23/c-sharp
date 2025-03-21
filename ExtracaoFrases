/*
solução deve declarar uma variável inteira chamada periodLocation que pode ser usada para manter o local do caractere de ponto dentro de uma cadeia de caracteres.

A solução deve incluir um loop foreach ou for externo que possa ser usado para processar cada elemento da cadeia de caracteres na matriz. A variável da cadeia de caracteres que será processada dentro dos loops deve ser chamada de myString.

No loop externo, a solução deve usar o método IndexOf() da classe String para obter a localização do primeiro caractere de ponto na variável myString. A chamada de método deve ser semelhante a: myString.IndexOf("."). Se não houver nenhum caractere de ponto na cadeia de caracteres, um valor de -1 será retornado.

A solução deve incluir um loop do-while ou while interno que possa ser usado para processar a variável myString.

No loop interno, a solução deve extrair e exibir (gravar no console) cada frase contida em cada uma das cadeias de caracteres processadas.

No loop interno, a solução não deve exibir o caractere de ponto.

No loop interno, a solução deve usar os métodos Remove(), Substring() e TrimStart() para processar as informações da cadeia de caracteres.

*/

using System;

public class ExtracaoFrases
{
    public static void Main(string[] args)
    {
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        int periodLocation;

        foreach (string myString in myStrings)
        {
            periodLocation = myString.IndexOf(".");

            string tempString = myString;

            while (periodLocation != -1)
            {
                string frase = tempString.Substring(0, periodLocation).TrimStart();
                Console.WriteLine(frase);

                tempString = tempString.Remove(0, periodLocation + 1);
                periodLocation = tempString.IndexOf(".");
            }

            // Exibe a última frase (se houver) quando não há mais pontos.
            if (!string.IsNullOrEmpty(tempString.Trim()))
            {
                Console.WriteLine(tempString.Trim());
            }
        }
    }
}
