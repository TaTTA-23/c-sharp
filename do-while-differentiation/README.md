# Diferenças entre Do-While e While

## Descrição
Este programa demonstra as **diferenças fundamentais** entre os loops `do-while` e `while` em C#.

## Funcionalidades
- Solicita entrada do usuário com pelo menos 3 caracteres
- Usa loop do-while para garantir pelo menos uma execução
- Valida a entrada antes de processar

## Conceitos Aprendidos
- **Loop do-while**: Executa o corpo pelo menos uma vez, depois verifica a condição
- **Loop while**: Verifica a condição primeiro, pode não executar nenhuma vez
- **Validação de entrada**: Como garantir que o usuário forneça dados válidos

## Como Executar
```bash
cd do-while-differentiation
dotnet run
```

## Saída Esperada
```
Entre a string containing at least three characters:
abc
```
*(se o usuário digitar "abc")*

```
Entre a string containing at least three characters:
ab
Your input is invalid, please try again.
ab
Your input is invalid, please try again.
abc
```
*(se o usuário digitar menos de 3 caracteres inicialmente)*

## Estrutura do Código
- Classe `Gerenciar` com método `Main()`
- Variável `readResult` para armazenar entrada do usuário
- Variável `validEntry` para controlar o loop
- Loop do-while que continua até entrada válida

## Principais Diferenças

### Do-While
- Executa **pelo menos uma vez**
- Verifica a condição **depois** da execução
- Útil quando você precisa fazer algo pelo menos uma vez

### While
- Pode não executar **nenhuma vez**
- Verifica a condição **antes** da execução
- Útil quando você quer verificar a condição primeiro

## Quando Usar Cada Um
- **Do-When**: Menus, validações, pelo menos uma execução necessária
- **While**: Processamento condicional, busca em dados, loops baseados em condições
