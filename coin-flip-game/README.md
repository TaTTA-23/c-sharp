# Jogo Cara ou Coroa

## Descrição
Implementação simples e elegante do clássico **jogo de cara ou coroa** em C#, demonstrando o uso de números aleatórios e operador ternário.

## Funcionalidades
- Gera um número aleatório entre 0 e 1
- Interpreta 0 como "heads" (cara)
- Interpreta 1 como "tails" (coroa)
- Exibe o resultado usando operador ternário

## Conceitos Aprendidos
- **Classe Random**: Geração de números aleatórios
- **Método Next(min, max)**: Geração de números em intervalo específico
- **Operador ternário (?)**: Condicional compacta em uma linha
- **Tipos de dados**: Uso de int para números inteiros
- **Namespace System**: Bibliotecas padrão do C#

## Como Executar
```bash
cd coin-flip-game
dotnet run
```

## Saída Esperada
```
heads
```
ou
```
tails
```

## Estrutura do Código
- Classe `Moeda` com método `Main()`
- Instância da classe `Random` para gerar números aleatórios
- Variável `flip` que armazena o resultado aleatório
- Operador ternário para interpretar e exibir o resultado

## Lógica do Jogo
1. Cria uma instância da classe `Random`
2. Gera número aleatório entre 0 e 1 (exclusivo do máximo)
3. Usa operador ternário para interpretar:
   - `flip == 0` → "heads"
   - `flip != 0` → "tails"
4. Exibe o resultado

## Aplicações Práticas
- Simulação de decisões aleatórias
- Jogos simples
- Demonstração de conceitos básicos
- Testes estatísticos simples
- Prototipagem de lógica probabilística

## Importância Educacional
- Introduz conceitos de aleatoriedade
- Demonstra uso de classes da biblioteca padrão
- Exercita operador ternário
- Base para jogos mais complexos
