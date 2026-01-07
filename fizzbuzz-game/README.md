# Jogo FizzBuzz

## Descrição
Implementação clássica do problema **FizzBuzz**, um exercício popular em programação que demonstra o uso de condicionais e loops.

## Funcionalidades
- Gera números de 1 a 100
- Para múltiplos de 3, exibe "Fizz"
- Para múltiplos de 5, exibe "Buzz"
- Para múltiplos de 3 e 5, exibe "FizzBuzz"
- Para outros números, exibe o próprio número

## Conceitos Aprendidos
- **Loops for**: Iteração controlada com contador
- **Operador módulo (%)**: Verificação de divisibilidade
- **Condicionais if-else if**: Múltiplas condições mutuamente exclusivas
- **Interpolação de strings**: Formatação de saída

## Como Executar
```bash
cd fizzbuzz-game
dotnet run
```

## Saída Esperada
```
1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
...
15 - FizzBuzz
16
...
```

## Estrutura do Código
- Classe `Program` com método `Main()`
- Loop `for` de 1 a 100
- Condicionais em cascata para verificar divisibilidade
- Uso de `&&` para combinar condições (múltiplos de 3 E 5)

## Lógica das Condições
1. `(i % 3 == 0) && (i % 5 == 0)` → "FizzBuzz"
2. `i % 3 == 0` → "Fizz"
3. `i % 5 == 0` → "Buzz"
4. Número original

## Importância Educacional
- Demonstra lógica de controle de fluxo
- Exercício comum em entrevistas de programação
- Introduz conceitos de modularidade e composição de condições
