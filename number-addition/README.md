# Adição de Números

## Descrição
Programa demonstrativo que explora **operações matemáticas fundamentais** em C#, incluindo adição, subtração, multiplicação, divisão e manipulação de tipos de dados.

## Funcionalidades
- Demonstra operações aritméticas básicas
- Mostra concatenação de strings com números
- Explica conversão implícita de tipos
- Compara divisão inteira vs decimal
- Usa interpolação de strings e concatenação

## Conceitos Aprendidos
- **Operadores aritméticos**: `+`, `-`, `*`, `/`
- **Concatenação de strings**: Combinando texto e números
- **Conversão implícita**: Entre tipos de dados
- **Parênteses**: Para controlar ordem de operações
- **Tipos decimais**: Para precisão em divisões
- **Interpolação vs concatenação**: Diferentes formas de formatar

## Como Executar
```bash
cd number-addition
dotnet run
```

## Saída Esperada
```
19
Bob sold 7 widgets.
Bob sold 14 widgets.
Sum: 12
Difference: 2
Product: 35
Quotient: 1
Decimal quotient: 1.4
```

## Operações Demonstradas
| Operação | Expressão | Resultado | Tipo |
|----------|-----------|-----------|------|
| Adição | `12 + 7` | 19 | int |
| Subtração | `7 - 5` | 2 | int |
| Multiplicação | `7 * 5` | 35 | int |
| Divisão inteira | `7 / 5` | 1 | int |
| Divisão decimal | `7.0m / 5` | 1.4 | decimal |

## Manipulação de Strings
```csharp
// Concatenação básica
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// Resultado: "Bob sold 7 widgets."

// Com parênteses (prioridade)
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
// Resultado: "Bob sold 14 widgets."

// Interpolação de strings
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
```

## Tipos de Dados Utilizados
- **int**: Números inteiros para operações básicas
- **string**: Texto para concatenação
- **decimal**: Para precisão em divisões decimais
- **Conversão implícita**: Entre tipos compatíveis

## Divisão: Inteira vs Decimal
### Divisão Inteira (`7 / 5`)
- **Resultado**: 1
- **Tipo**: int
- **Comportamento**: Trunca a parte decimal
- **Uso**: Quando só interessa o quociente inteiro

### Divisão Decimal (`7.0m / 5`)
- **Resultado**: 1.4
- **Tipo**: decimal
- **Comportamento**: Preserva precisão decimal
- **Uso**: Cálculos que precisam de precisão

## Aplicações Práticas
- **Calculadoras**: Operações matemáticas básicas
- **Relatórios**: Cálculos financeiros
- **Validações**: Verificação de resultados
- **Interfaces**: Exibição de dados calculados
- **Algoritmos**: Processamento numérico

## Importância Educacional
- **Fundamentos**: Base da programação
- **Tipos de dados**: Compreensão de conversões
- **Operações**: Essenciais para qualquer aplicação
- **Formato de saída**: Apresentação de resultados
- **Precisão**: Quando usar cada tipo numérico
