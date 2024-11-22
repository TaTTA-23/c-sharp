/* Escrever código que use espaço em branco de modo eficaz para transmitir a relação de linhas de código.
 */

using System;

public class DiceRoller
{
    public static void Main(string[] args)
    {
        
   Random dice = new Random();  // criaçao do objeto Random
   int roll1 = dice.Next(1, 7); // lança o dado 1
   int roll2 = dice.Next(1, 7);  //lança o dado 2
   int roll3 = dice.Next(1, 7); // lança dado 3
   int total = roll1 + roll2 + roll3;
   
   Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
   
   if ((roll1 == roll2) || (roll2 == roll3)|| (roll1 == roll3))
   {
       if ((roll1 == roll2) && (roll2==roll3))
   {
       Console.WriteLine("You rolled triples! +6 bonus to total!");
       total +=6;
   }
   else
   {
       Console.WriteLine("You rolled doubles! +2 bonus total");
       total +=2;
    }
  }
 }
}
