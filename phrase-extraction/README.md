# Extração de Frases

## Descrição
Programa que demonstra técnicas avançadas de **manipulação de strings** em C#, extraindo frases individuais de strings que contêm múltiplas sentenças separadas por pontos.

## Funcionalidades
- Processa arrays de strings contendo múltiplas frases
- Localiza pontos separadores usando `IndexOf()`
- Extrai e exibe cada frase individualmente
- Remove caracteres de ponto das frases exibidas
- Usa métodos de string como `Substring()`, `Remove()`, `TrimStart()`

## Conceitos Aprendidos
- **Métodos de string**: `IndexOf()`, `Substring()`, `Remove()`, `TrimStart()`
- **Loops while**: Processamento condicional baseado em localização de caracteres
- **Manipulação de substrings**: Extração de partes de strings
- **Arrays de strings**: Processamento de coleções de texto
- **Controle de fluxo**: Loops aninhados e validação de condições

## Como Executar
```bash
cd phrase-extraction
dotnet run
```

## Saída Esperada
```
I like pizza
 I like roast chicken
 I like salad
I like all three of the menu choices
```

## Estrutura do Código
- Classe `ExtracaoFrases` com método `Main()`
- Array `myStrings` com strings de exemplo
- Loop `foreach` para processar cada string
- Loop `while` interno para extrair frases baseado na localização do ponto
- Uso combinado de métodos de string para processamento

## Métodos de String Utilizados
- **`IndexOf(".")`**: Encontra a posição do primeiro ponto
- **`Substring(0, position)`**: Extrai a parte antes do ponto
- **`TrimStart()`**: Remove espaços do início da string
- **`Remove(0, position + 1)`**: Remove a parte já processada
- **`string.IsNullOrEmpty()`**: Verifica se a string está vazia

## Lógica do Algoritmo
1. Para cada string no array:
   - Encontra a localização do primeiro ponto
   - Extrai a frase antes do ponto
   - Remove a frase processada da string
   - Repete até não haver mais pontos
   - Exibe a última frase (se houver)

## Aplicações Práticas
- Processamento de texto
- Análise de sentenças
- Limpeza de dados de texto
- Parsing de documentos
- Extração de informações de logs
