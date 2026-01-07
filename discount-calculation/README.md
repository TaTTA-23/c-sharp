# Cálculo de Desconto com Operador Ternário

## Descrição
Este programa demonstra o uso do **operador ternário** para cálculo de descontos em C#.

## Funcionalidades
- Aplica desconto de R$ 100 para vendas acima de R$ 1.000
- Aplica desconto de R$ 50 para vendas de R$ 1.000 ou menos
- Utiliza operador ternário para lógica condicional concisa

## Conceitos Aprendidos
- **Operador ternário (`? :`)**: Forma concisa de escrever condicionais
- **Sintaxe**: `condição ? valor_se_verdadeiro : valor_se_falso`
- **Expressões condicionais**: Alternativa compacta ao if-else

## Como Executar
```bash
cd discount-calculation
dotnet run
```

## Saída Esperada
```
Discount: 100
```
*(considerando saleAmount = 1001)*

## Estrutura do Código
- Classe `Amount` com método `Main()`
- Variável `saleAmount` com valor de exemplo
- Expressão ternária: `(saleAmount > 1000 ? 100 : 50)`
- Interpolação de strings para exibir o resultado

## Vantagens do Operador Ternário
- Código mais conciso e legível
- Útil para atribuições condicionais simples
- Pode ser usado em expressões e não apenas em statements

## Exemplo de Uso
```csharp
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
