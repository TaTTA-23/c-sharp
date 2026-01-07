# Loop Do-While

## Descrição
Programa demonstrativo que ensina o **loop do-while** em C#, uma estrutura de controle que garante a execução do bloco de código pelo menos uma vez, verificando a condição após a execução.

## Funcionalidades
- Demonstra loop do-while básico
- Garante execução mínima uma vez
- Verifica condição após execução
- Útil para menus e validação
- Controle de fluxo pós-execução

## Conceitos Aprendidos
- **Loop do-while**: Execução garantida pelo menos uma vez
- **Pós-teste**: Condição verificada após o bloco
- **Execução garantida**: Diferença fundamental do while
- **Casos de uso**: Menus, validação, entrada obrigatória
- **Fluxo de execução**: Uma ou mais execuções

## Como Executar
```bash
cd do-while-loop
dotnet run
```

## Estrutura do Código
- Bloco de código executado primeiro
- Condição while verificada após execução
- Repetição baseada na condição

## Comparação While vs Do-While
| Característica | While | Do-While |
|----------------|-------|----------|
| **Verificação** | Antes da execução | Após a execução |
| **Execuções mínimas** | Zero | Uma |
| **Sintaxe** | `while(condição)` | `do { } while(condição)` |
| **Quando usar** | Número desconhecido de iterações | Execução garantida necessária |

## Quando Usar Do-While
- **Menus interativos**: Pelo menos uma escolha é obrigatória
- **Validação de entrada**: Deve processar pelo menos uma vez
- **Inicialização**: Configurar algo antes de verificar
- **UI interativa**: Esperar interação do usuário

## Sintaxe
```csharp
do
{
    // Código executado pelo menos uma vez
    // Lógica que pode modificar a condição
} while (condição);
```

## Fluxo de Execução
```
Executar código
  ↓
Verificar condição (true/false)
  ↓
Condição é false? → Fim
Condição é true? → Executar código novamente → Verificar condição
```

## Aplicações Práticas
- **Sistemas de menu**: Opção pelo menos uma vez
- **Processamento de arquivos**: Ler pelo menos uma linha
- **Validação de dados**: Verificar entrada pelo menos uma vez
- **Configuração**: Setup antes de verificar estado

## Exemplo Prático
```csharp
string opcao;
do
{
    Console.WriteLine("Escolha uma opção (1-3):");
    Console.WriteLine("1 - Processar");
    Console.WriteLine("2 - Relatório");
    Console.WriteLine("3 - Sair");
    opcao = Console.ReadLine();
    
    // Processar opção escolhida
} while (opcao != "3");
```

## Diferenças Chave
- **Do-While**: Executa primeiro, verifica depois
- **While**: Verifica primeiro, executa depois
- **Flexibilidade**: Escolha baseada na necessidade do problema
- **Robustez**: Do-while garante processamento mínimo

## Importância Educacional
- **Estruturas de controle**: Diversidade de opções
- **Problem-solving**: Escolher a ferramenta certa
- **UX**: Garantir interação mínima do usuário
- **Robustez**: Código mais resistente a condições edge
- **Boas práticas**: Quando usar cada tipo de loop
