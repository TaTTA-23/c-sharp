# Demonstração de Foreach

## Descrição
Programa demonstrativo que ensina o **uso do loop foreach** em C#, exemplificando como iterar através de arrays de strings de forma simples e limpa.

## Funcionalidades
- Cria array de strings com nomes
- Demonstra iteração simples com foreach
- Exibe cada elemento do array
- Usa estrutura de classes e construtores
- Código limpo e bem organizado

## Conceitos Aprendidos
- **Loop foreach**: Iteração simplificada sobre coleções
- **Arrays de strings**: Armazenamento de sequências de texto
- **Classes e construtores**: Organização orientada a objetos
- **Instanciação de objetos**: Criação de objetos da classe
- **Namespace System**: Bibliotecas padrão do C#
- **Sintaxe limpa**: Código legível e bem estruturado

## Como Executar
```bash
cd foreach-method
dotnet run
```

## Saída Esperada
```
Rowena
Robin
Bao
```

## Estrutura do Código
- **Classe principal**: `Program` com método `Main()`
- **Classe de negócio**: `PedidosOrderIDs` para lógica de pedidos
- **Array de pedidos**: `pedidosOrderIDs[]` armazena nomes de pedidos
- **Construtor**: Inicializa array e executa loop foreach
- **Iteração**: Exibe cada nome de pedido

## Dados dos Pedidos
| Índice | Nome do Pedido |
|--------|----------------|
| 0 | Rowena |
| 1 | Robin |
| 2 | Bao |

## Vantagens do Foreach
### vs For Loop Tradicional
- **Mais limpo**: Sintaxe simplificada
- **Seguro**: Evita erros de índice
- **Legível**: Código mais fácil de entender
- **Orientado a objeto**: Funciona com qualquer coleção IEnumerable

### Sintaxe Comparativa
```csharp
// Com for (tradicional)
for (int i = 0; i < pedidosOrderIDs.Length; i++)
{
    Console.WriteLine(pedidosOrderIDs[i]);
}

// Com foreach (recomendado)
foreach (string pedido in pedidosOrderIDs)
{
    Console.WriteLine(pedido);
}
```

## Quando Usar Foreach
- **Iteração simples**: Quando precisa acessar todos os elementos
- **Somente leitura**: Quando não modifica a coleção
- **Legibilidade**: Quando quer código mais limpo
- **Coleções**: Arrays, Lists, e outras IEnumerable

## Aplicações Práticas
- Processamento de listas de usuários
- Exibição de itens em catálogos
- Validação de dados em lote
- Relatórios e listagens
- Navegação em menus

## Importância Educacional
- **Fundamental**: Base para programação moderna
- **Boas práticas**: Código limpo e organizado
- **OOP**: Introdução a classes e objetos
- **Estrutura**: Organização profissional de código
- **Fundação**: Base para estruturas de dados mais complexas
