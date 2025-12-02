/*
Você deve usar a instrução do-while ou a instrução while como um loop de jogo externo.
O herói e o monstro começam com 10 pontos de vida.
Todos os ataques têm um valor entre 1 e 10.
O herói ataca primeiro.
Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
Imprima quem foi o vencedor.
*/

using System;

public class JogoDeBatalha

{
    public static void Main(string[] args)
   { 

    int vidaHeroi = 10;
    int vidaMonstro = 10;
    Random random = new Random();
    
    do
    {
        //heroi ataca
        int ataqueHeroi = random.Next(1, 11);
        vidaMonstro -= ataqueHeroi;
        Console.WriteLine($"Heroi ataca o mostro e causa {ataqueHeroi} de dano. Vida do monstro: {Math.Max (0, vidaMonstro)}");// Math.Max para garantir que a vida não seja negativa
        
        if (vidaMonstro <= 0) 
    {
    Console.WriteLine("Heroi venceu!");
    break;
    } 
    //Monstro ataca
    int ataqueMonstro = random.Next(1, 11);
    vidaHeroi -= ataqueMonstro;
    Console.WriteLine($"Monstro ataca o heroi e causa {ataqueMonstro} de dano. Vida do heroi: {Math.Max(0, vidaHeroi)}");
    
    if (vidaHeroi <= 0)
    {
        Console.WriteLine("Monstro venceu!");
        break;
    }
    
    }while (vidaHeroi > 0 && vidaMonstro > 0);
  }
}
