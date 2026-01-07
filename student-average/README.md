# Cálculo de Média de Estudantes

## Descrição
Sistema avançado de **cálculo de médias acadêmicas** em C# que demonstra o uso de arrays multidimensionais, loops foreach aninhados, sistema de pontuação com créditos extras e classificação por letras.

## Funcionalidades
- Processa notas de múltiplos estudantes
- Calcula médias ponderadas com créditos extras
- Atribui classificações por letras (A+ até F)
- Exibe relatório formatado com resultados
- Diferencia créditos extras (10% do valor do exame)
- Sistema robusto de avaliação académica

## Conceitos Aprendidos
- **Arrays multidimensionais**: Armazenamento de dados de estudantes
- **Loops foreach aninhados**: Processamento de coleções complexas
- **Conversão de tipos**: `int` para `decimal` para precisão decimal
- **Condições encadeadas**: Sistema de classificação por letras
- **Interpolação de strings**: Formatação de relatórios
- **Lógica académica**: Cálculos de médias e pontuações

## Como Executar
```bash
cd student-average
dotnet run
```

## Saída Esperada
```
Student		Grade
Sophia		91.6	B-
Andrew		91.6	B-
Emma		89.6	B-
Logan		91.8	B-
Press the Enter key to continue
```

## Estrutura do Código
- Arrays de notas para cada estudante (Sophia, Andrew, Emma, Logan)
- Array de nomes dos estudantes
- Variáveis de controle para cálculos
- Loops foreach aninhados para processamento
- Sistema de classificação por letras com 12 faixas

## Dados dos Estudantes
- **Sophia**: 7 notas (5 exames + 2 créditos extras)
- **Andrew**: 6 notas (5 exames + 1 crédito extra)
- **Emma**: 8 notas (5 exames + 3 créditos extras)
- **Logan**: 6 notas (5 exames + 1 crédito extra)

## Sistema de Pontuação
### Exames Regulares
- Contagem completa na média
- Base para cálculo de créditos extras

### Créditos Extras
- Valor = 10% da nota do exame
- Exemplo: nota 90 → crédito extra = 9 pontos

## Classificação por Letras
| Faixa | Letra | Faixa | Letra |
|-------|-------|-------|-------|
| 97-100 | A+ | 67-69 | D+ |
| 93-96 | A | 63-66 | D |
| 90-92 | A- | 60-62 | D- |
| 87-89 | B+ | < 60 | F |
| 83-86 | B | | |
| 80-82 | B- | | |
| 77-79 | C+ | | |
| 73-76 | C | | |
| 70-72 | C- | | |

## Lógica dos Cálculos
1. **Identificação**: Loop pelos nomes dos estudantes
2. **Atribuição**: Associa array de notas ao estudante atual
3. **Processamento**: Loop pelas notas do estudante
4. **Cálculo base**: Soma das notas de exame
5. **Créditos extras**: Adiciona 10% das notas extras
6. **Média final**: Soma total ÷ número de exames
7. **Classificação**: Atribui letra baseada na média

## Aplicações Práticas
- Sistemas de gestão académica
- Relatórios de desempenho
- Calculadoras de média ponderada
- Sistemas de avaliação
- Aplicações educacionais

## Importância Educacional
- Demonstra arrays e loops complexos
- Exercita lógica condicional avançada
- Introduz conceitos de precisão decimal
- Simula cenários reais de avaliação
- Prepara para sistemas académicos completos
