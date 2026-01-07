# Loop While

## Descrição
Programa demonstrativo que ensina o **loop while** em C#, uma estrutura de controle que executa um bloco de código enquanto uma condição específica for verdadeira.

## Funcionalidades
- Demonstra loop while básico
- Mostra condição antes da execução
- Executa zero ou mais vezes
- Controle de fluxo baseado em condição
- Exemplo prático de repetição controlada

## Conceitos Aprendidos
- **Loop while**: Repetição baseada em condição
- **Condição de parada**: Controlando quando parar
- **Verificação prévia**: Condição avaliada antes da execução
- **Variáveis de controle**: Modificando estado para controlar loop
- **Fluxo de execução**: Zero ou mais execuções

## Como Executar
```bash
cd while-loop
dotnet run
```

## Estrutura do Código
- Variável de controle inicializada
- Condição while baseada na variável
- Bloco de código executado repetidamente
- Modificação da variável dentro do loop

## Características do While
| Aspecto | Descrição |
|---------|-----------|
| **Verificação** | Antes da execução (pre-test) |
| **Execuções** | Zero ou mais vezes |
| **Condição** | Deve ser verdadeira para continuar |
| **Uso** | Quando número de iterações é desconhecido |

## Quando Usar While
- **Leitura de arquivos**: Até chegar ao fim
- **Entrada do usuário**: Até receber comando válido
- **Processamento condicional**: Até condição específica
- **Aguardar eventos**: Até condição externa ser atendida

## Sintaxe
```csharp
while (condição)
{
    // Código a ser executado
    // Deve modificar a condição para evitar loop infinito
}
```

## Exemplo de Fluxo
```
Início
  ↓
Verificar condição (true/false)
  ↓
Condição é false? → Fim
Condição é true? → Executar código → Voltar para verificar condição
```

## Cuidados Importantes
- **Loop infinito**: Garantir que condição se torne false
- **Variável de controle**: Inicializar antes do loop
- **Modificação**: Alterar variável dentro do loop
- **Condição complexa**: Usar parênteses para clareza

## Aplicações Práticas
- **Menus interativos**: Até usuário sair
- **Validação de entrada**: Até entrada válida
- **Processamento de dados**: Até fim dos dados
- **Games**: Loop principal do jogo
- **Serviços**: Processamento contínuo

## Importância Educacional
- **Fundamental**: Estrutura básica de controle
- **Flexibilidade**: Para problemas dinâmicos
- **Lógica**: Pensamento condicional
- **Debugging**: Identificar loops problemáticos
- **Performance**: Otimização de condições
