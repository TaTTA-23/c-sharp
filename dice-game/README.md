# Jogo de Dados

## Descrição
Implementação de um **jogo de dados** em C# que demonstra conceitos avançados de lógica condicional, incluindo múltiplas condições, operadores lógicos e sistema de pontuação com bônus.

## Funcionalidades
- Rola três dados virtuais (1-6)
- Calcula soma total dos três dados
- Aplica bônus por dados iguais:
  - Dois dados iguais: +2 pontos
  - Três dados iguais: +6 pontos
- Determina vitória/derrota baseada na pontuação final
- Exibe detalhes da jogada e resultado

## Conceitos Aprendidos
- **Classe Random**: Geração de números aleatórios para dados
- **Operadores lógicos**: `&&` (E), `||` (OU)
- **Condições aninhadas**: Múltiplas estruturas if-else
- **Operadores de comparação**: `>=`, `<`, `==`
- **Interpolação de strings**: Formatação de saída detalhada
- **Lógica de jogos**: Sistema de pontuação e bônus

## Como Executar
```bash
cd dice-game
dotnet run
```

## Saída Esperada
```
Dice roll: 4 + 2 + 6 = 12
Sorry, you lose.
```
ou
```
Dice roll: 5 + 5 + 6 = 16
You rolled doubles! +2 bonus to total!
You win!
```
ou
```
Dice roll: 6 + 6 + 6 = 18
You rolled triples! +6 bonus to total!
You win!
```

## Estrutura do Código
- Classe `Program` com método `Main()`
- Três variáveis para armazenar resultados dos dados
- Variável `total` para soma e pontuação final
- Condições encadeadas para diferentes cenários de jogo
- Operadores lógicos para detectar padrões

## Lógica do Jogo
1. **Rolagem**: Gera três números aleatórios (1-6)
2. **Cálculo base**: Soma os três dados
3. **Verificação de bônus**:
   - Se dois dados iguais: +2 pontos
   - Se três dados iguais: +6 pontos (prioridade sobre +2)
4. **Determinação do resultado**:
   - Pontuação final ≥ 15: Vitória
   - Pontuação final < 15: Derrota

## Operadores Utilizados
- **`dice.Next(1, 7)`**: Gera números de 1 a 6
- **`total >= 15`**: Condição de vitória
- **`||` (OU)**: Detecta se pelo menos dois dados são iguais
- **`&&` (E)**: Detecta se todos os três dados são iguais
- **`+=`**: Adiciona bônus à pontuação total

## Aplicações Práticas
- Desenvolvimento de jogos
- Sistemas de pontuação
- Lógica de concursos e competições
- Simulações de probabilidade
- Aplicações educacionais sobre estatísticas

## Importância Educacional
- Demonstra lógica condicional complexa
- Exercita operadores lógicos
- Introduz conceitos de jogos e pontuação
- Prepara para desenvolvimento de jogos mais complexos
