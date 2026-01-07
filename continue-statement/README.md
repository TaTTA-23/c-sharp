# Instrução Continue em Loops

## Descrição
Este programa demonstra o uso da instrução `continue` em loops do-while em C#.

## Funcionalidades
- Gera números aleatórios entre 1 e 10
- Usa a instrução `continue` para pular números maiores ou iguais a 8
- Executa até encontrar o número 7

## Conceitos Aprendidos
- **Instrução `continue`**: Pula a execução restante do loop atual e vai para a próxima iteração
- **Loop do-while**: Executa pelo menos uma vez, mesmo se a condição for falsa
- **Controle de fluxo**: Como modificar o comportamento normal dos loops

## Como Executar
```bash
cd continue-statement
dotnet run
```

## Saída Esperada
```
Números menores que 8 (excluindo 8 e 9):
2
5
1
3
...
```

## Estrutura do Código
- Classe `Aleatorio` com método `Main()`
- Loop do-while com geração de números aleatórios
- Condição `if (current >= 8) continue;` para filtrar números
- Loop continua até encontrar o número 7

## Pontos Importantes
- A instrução `continue` força o loop a ir para a próxima iteração
- Útil para pular elementos que não atendem a uma condição específica
- Diferente de `break`, que sai completamente do loop
