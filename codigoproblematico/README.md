# Código Problemático - Demonstração de Correção de Bugs

## Descrição

Este projeto demonstra a correção de um código problemático em C# que continha vários erros de escopo e inicialização de variáveis.

## Problemas do Código Original

O código original apresentava os seguintes problemas:

1. **Variável `total` não inicializada**: A variável `total` era declarada dentro do loop `foreach` sem ser inicializada, causando erro de compilação.

2. **Variável `found` fora de escopo**: A variável `bool found` era declarada dentro de um bloco `if` e utilizada fora dele, causando erro de compilação.

3. **Estrutura desorganizada**: O código original misturava comentários com código de forma desorganizada.

## Correções Aplicadas

1. **Inicialização correta de `total`**: A variável foi inicializada com `int total = 0;` antes do loop.

2. **Declaração de `found` no escopo correto**: A variável foi movida para o escopo do método, antes do loop.

3. **Estrutura organizada**: O código foi reorganizado seguindo boas práticas de programação.

## O que o programa faz

1. Cria um array de inteiros: `{ 4, 8, 15, 16, 23, 42 }`
2. Calcula a soma de todos os elementos do array
3. Verifica se o número 42 está presente no array
4. Imprime uma mensagem indicando se o número 42 foi encontrado
5. Imprime o total da soma dos números

## Saída esperada

```
Set contains 42
Total: 108
```

## Como executar

```bash
dotnet run
```

Ou compile e execute diretamente:

```bash
csc codigoproblematico.cs
dotnet codigoproblematico.exe
```

