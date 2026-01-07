# Blocos de Código e Escopo de Variáveis

## Descrição
Este programa demonstra o conceito de **blocos de código** e **escopo de variáveis** em C#.

## Funcionalidades
- Demonstra como variáveis declaradas dentro de um bloco de código (`{}`) têm escopo limitado
- Mostra a diferença entre variáveis declaradas dentro e fora de blocos condicionais
- Ilustra o conceito de encapsulamento de variáveis

## Conceitos Aprendidos
- **Blocos de código**: Conjuntos de instruções agrupadas entre chaves `{}`
- **Escopo de variáveis**: Define onde uma variável pode ser acessada
- **Variáveis locais**: Variáveis declaradas dentro de blocos são locais àquele bloco

## Como Executar
```bash
cd blockcode-example
dotnet run
```

## Saída Esperada
```
Inside the code block: 10
```

## Estrutura do Código
- Classe `Bloco` com método `ExecutarBloco()`
- Demonstração de variável `value` declarada dentro do bloco `if`
- Variável `flag` declarada no método, acessível em todo o escopo do método
