# Debugging - Código Problemático Corrigido

## Descrição
Este programa demonstra um **exemplo de debugging** onde um código problemático é identificado e corrigido. Mostra os erros comuns ao trabalhar com arrays, loops e escopo de variáveis.

## Funcionalidades
- Processa um array de números inteiros
- Calcula a soma total dos números
- Verifica se o número 42 está presente no array
- Exibe o total e a informação sobre a presença de 42

## Conceitos Aprendidos
- **Declaração de variáveis**: Onde e como declarar variáveis corretamente
- **Escopo de variáveis**: Problemas que surgem quando variáveis são declaradas no lugar errado
- **Debugging**: Identificação e correção de erros de código
- **Arrays e loops**: Uso correto de foreach com arrays
- **Variáveis booleanas**: Controle de estado com variáveis bool

## Como Executar
```bash
cd debugging-code
dotnet run
```

## Saída Esperada
```
Set contains 42
Total: 108
```

## Problemas Identificados no Código Original
1. **Variável `total` dentro do loop**: Causaria erro de compilação
2. **Variável `found` dentro do `if`**: Não seria acessível fora do escopo
3. **Declaração de variáveis**: Variáveis devem ser declaradas no escopo correto

## Correções Aplicadas
- Movido `int total = 0;` para fora do loop
- Movido `bool found = false;` para fora do escopo do if
- Declaradas as variáveis no escopo correto do método

## Estrutura do Código Corrigido
- Array `numbers` com valores: {4, 8, 15, 16, 23, 42}
- Loop `foreach` para processar cada número
- Condicional `if` para verificar se é 42
- Resultado final exibindo se 42 foi encontrado e o total

## Lições de Debugging
- Sempre declare variáveis no escopo adequado
- Teste o código após cada alteração
- Use nomes descritivos para variáveis
- Verifique se variáveis são acessíveis onde precisam ser usadas
