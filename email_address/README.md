# Gerador de Endereços de Email

Este programa em C# gera endereços de email para funcionários corporativos e externos com base em seus nomes.

## Funcionalidade

O programa utiliza duas listas de nomes (corporativos e externos) e cria endereços de email seguindo uma lógica específica:

- **Domínio padrão para corporativos**: `contoso.com`
- **Domínio para externos**: `hayworth.com`
- **Formato do email**: As duas primeiras letras do primeiro nome + o sobrenome completo, tudo em minúsculas.

## Como Funciona

1. Define matrizes bidimensionais com nomes de funcionários corporativos e externos.
2. Itera sobre cada matriz e chama a função `DisplayEmail` para gerar o email.
3. A função `DisplayEmail` constrói o endereço de email e o exibe no console.

## Exemplo de Saída

Para os nomes fornecidos, o programa gera emails como:
- roBavin@contoso.com
- siBright@contoso.com
- ... (para corporativos)
- viAshton@hayworth.com
- coDysart@hayworth.com
- ... (para externos)

## Uso

Para executar o programa:
1. Certifique-se de ter o .NET SDK instalado.
2. Navegue até a pasta `email_address`.
3. Execute `dotnet run`.

## Código Principal

O código principal está em `Program.cs`, que inclui a lógica de geração de emails e a função auxiliar `DisplayEmail`.
