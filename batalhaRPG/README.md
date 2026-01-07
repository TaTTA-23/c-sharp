# Batalha RPG

Este é um programa simples de batalha em RPG escrito em C#. O jogo simula uma batalha entre um herói e um monstro, onde ambos começam com 10 pontos de vida. Os ataques são aleatórios, variando de 1 a 10 de dano.

## Funcionalidades

- O herói ataca primeiro.
- Cada ataque reduz a vida do oponente.
- A batalha continua até que a vida de um dos personagens chegue a zero ou menos.
- O programa imprime o dano causado e a vida restante após cada ataque.
- No final, declara o vencedor.

## Como executar

Compile e execute o arquivo `batalhaRPG.cs` usando um compilador C# compatível, como o .NET CLI:

```
dotnet run batalhaRPG.cs
```

Ou compile primeiro:

```
csc batalhaRPG.cs
```

Em seguida, execute o executável gerado.
