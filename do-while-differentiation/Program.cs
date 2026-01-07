// A instrução do-while: executa condicionalmente o corpo uma ou mais vezes.
// A instrução while: executa condicionalmente o corpo zero ou mais vezes.

public class Gerenciar

{
    public static void Main(string[] args)
   { 

    string? readResult;
    bool validEntry = false;
    Console.WriteLine("Entre a string containing at least three characters:");
    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            if (readResult.Length >= 3)
            {
            validEntry = true;
            }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
}while (validEntry == false);
    }
    }
