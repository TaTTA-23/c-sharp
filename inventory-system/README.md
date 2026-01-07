# Sistema de Inventário

## Descrição
Sistema de **gestão de inventário** em C# que demonstra o uso de classes, arrays, construtores e loops foreach para processar e relatar dados de estoque empresarial.

## Funcionalidades
- Inicializa inventário com produtos em diferentes compartimentos
- Calcula total de itens no estoque
- Gera relatório individual por compartimento
- Mantém running total (total acumulado)
- Exibe resumo final do inventário
- Sistema modular com classe separada para organização

## Conceitos Aprendidos
- **Classes e objetos**: Criação de classe `InventoryOrder`
- **Construtores**: Inicialização de dados no construtor
- **Arrays**: Armazenamento de dados de inventário
- **Loops foreach**: Processamento de dados de estoque
- **Variáveis de instância**: Campos da classe
- **Encapsulamento**: Organização de dados e métodos
- **Running totals**: Cálculo de acumulados em tempo real

## Como Executar
```bash
cd inventory-system
dotnet run
```

## Saída Esperada
```
Itens no inventário inicial:
Bin 1 = 200 items (Running total: 200).
Bin 2 = 450 items (Running total: 650).
Bin 3 = 700 items (Running total: 1350).
Bin 4 = 175 items (Running total: 1525).
Bin 5 = 250 items (Running total: 1775).
We have 1775 items in inventory.
```

## Estrutura do Código
- **Classe principal**: `Program` com método `Main()`
- **Classe de negócio**: `InventoryOrder` para lógica de inventário
- **Array de estoque**: `inventoryOrder[]` armazena quantidades por compartimento
- **Variáveis de controle**: `sum` (total acumulado) e `bin` (contador de compartimentos)
- **Construtor**: Inicializa dados e exibe relatório

## Dados do Inventário
| Compartimento | Quantidade | Running Total |
|---------------|------------|---------------|
| Bin 1 | 200 | 200 |
| Bin 2 | 450 | 650 |
| Bin 3 | 700 | 1.350 |
| Bin 4 | 175 | 1.525 |
| Bin 5 | 250 | 1.775 |
| **TOTAL** | **1.775** | - |

## Lógica do Sistema
1. **Inicialização**: Construtor cria array de inventário
2. **Processamento**: Loop foreach percorre cada compartimento
3. **Cálculo**: Soma itens e incrementa running total
4. **Relatório**: Exibe linha por compartimento com total acumulado
5. **Resumo**: Mostra total final do inventário

## Recursos Empresariais
- **Trilha de auditoria**: Running total para verificação
- **Relatório por compartimento**: Visibilidade individual
- **Total consolidado**: Resumo para tomada de decisão
- **Identificação de discrepâncias**: Base para redução de estoque

## Aplicações Práticas
- Sistemas de warehouse management
- Controle de estoque empresarial
- Relatórios de inventário
- Auditoria de produtos
- Gestão de logística
- Sistemas ERP (Enterprise Resource Planning)

## Importância Educacional
- Demonstra uso de classes e objetos
- Exercita loops com dados reais
- Introduz conceitos de negócios
- Prepara para sistemas de gestão
- Mostra organização de código profissional
