# Detecção de Dados Fraudulentos

## Descrição
Sistema de **detecção de fraudes** em C# que identifica pedidos suspeitos baseados em padrões de identificação. Pedidos que começam com "B" têm 25x mais chance de serem fraudulentos.

## Funcionalidades
- Analisa lista de IDs de pedidos
- Identifica pedidos que começam com "B"
- Ignora diferenciação de maiúsculas/minúsculas
- Exibe apenas pedidos suspeitos para investigação
- Sistema de classe orientada a objetos

## Conceitos Aprendidos
- **Detecção de padrões**: Uso de `StartsWith()` em strings
- **Case-insensitive comparison**: `StringComparison.OrdinalIgnoreCase`
- **Classes e métodos**: Organização orientada a objetos
- **Arrays de strings**: Armazenamento de dados de pedidos
- **Loop foreach**: Processamento de coleções
- **Condições**: Verificação de critérios específicos

## Como Executar
```bash
cd fraud-detection
dotnet run
```

## Saída Esperada
```
Itens no inventário que começam com 'B': 
B123
B177
B179
```

## Dados dos Pedidos
| ID | Status | Observação |
|----|--------|-------------|
| B123 | **SUSPETO** | 25x mais chance de fraude |
| C234 | Normal | - |
| A345 | Normal | - |
| C15 | Normal | - |
| B177 | **SUSPETO** | 25x mais chance de fraude |
| G3003 | Normal | - |
| C235 | Normal | - |
| B179 | **SUSPETO** | 25x mais chance de fraude |

## Estatísticas do Sistema
- **Total de pedidos**: 8
- **Pedidos suspeitos**: 3 (37.5%)
- **Pedidos normais**: 5 (62.5%)

## Lógica de Detecção
1. **Carregamento**: Array com IDs de pedidos
2. **Iteração**: Loop foreach percorre todos os pedidos
3. **Verificação**: `item.StartsWith("B", StringComparison.OrdinalIgnoreCase)`
4. **Identificação**: Pedidos que começam com "B" são suspeitos
5. **Exibição**: Lista apenas os pedidos para investigação

## Métodos de String Utilizados
- **`StartsWith()`**: Verifica se string começa com caractere específico
- **`StringComparison.OrdinalIgnoreCase`**: Comparação sem diferenciação de caso
- **Case-insensitive**: Funciona com "B", "b", "B123", "b456"

## Aplicações Práticas
- **Sistemas antifraude**: Detecção de transações suspeitas
- **Segurança**: Identificação de padrões de risco
- **Compliance**: Auditoria e relatórios regulatórios
- **Machine Learning**: Feature engineering para algoritmos
- **Risk Assessment**: Avaliação de risco automatizada

## Algoritmo Anti-Fraude
```csharp
if (item.StartsWith("B", StringComparison.OrdinalIgnoreCase))
{
    // ROTA = 25x maior chance de fraude
    // AGUARDAR INVESTIGAÇÃO MANUAL
    Console.WriteLine($"ALERTA: {item}");
}
```

## Importância para Segurança
- **Detecção precoce**: Identifica riscos antes do processamento
- **Redução de perdas**: Evita transações fraudulentas
- **Automação**: Processa grandes volumes rapidamente
- **Integração**: Pode ser usado em sistemas existentes
- **Escalabilidade**: Funciona com milhões de transações

## Expandindo o Sistema
### Futuras Funcionalidades
- Múltiplos padrões de risco
- Machine Learning para detecção
- Logs e auditoria
- Integração com APIs
- Dashboards em tempo real

## Importância Educacional
- **Aplicação real**: Problema de segurança real
- **Lógica de negócio**: Algoritmos de decisão
- **Performance**: Eficiência em processamento
- **Manutenibilidade**: Código extensível
- **Critical thinking**: Desenvolvimento de soluções
