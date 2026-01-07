# Demonstração de Switch Case

## Descrição
Programa demonstrativo que ensina o uso da **instrução switch** em C#, uma estrutura de controle de fluxo que permite selecionar uma seção de código específica baseada em uma correspondência de padrão.

## Funcionalidades
- Demonstra uso básico de switch com strings
- Mostra cases para diferentes frutas
- Inclui case default para valores não especificados
- Usa break para controlar o fluxo
- Exibe informações específicas para cada fruta

## Conceitos Aprendidos
- **Instrução switch**: Alternativa ao if-else para múltiplas condições
- **Cases**: Seções específicas de código para cada valor
- **Default case**: Ação para valores não especificados
- **Break statement**: Interrompe a execução do switch
- **String matching**: Comparação de strings em switch
- **Interpolação de strings**: Formatação de saída

## Como Executar
```bash
cd switch-demo
dotnet run
```

## Saída Esperada
```
 App will display information for apple.
```

## Estrutura do Código
- **Variável de teste**: `fruit` inicializada com "apple"
- **Switch expression**: Verifica o valor de `fruit`
- **Cases disponíveis**:
  - "apple" → Exibe informação da maçã
  - "banana" → Exibe informação da banana
  - "cherry" → Exibe informação da cereja
- **Default**: Para frutas não especificadas

## Casos de Uso Demonstrados
| Valor | Saída |
|-------|-------|
| "apple" | "App will display information for apple." |
| "banana" | "App wil display information for banana." |
| "cherry" | "App will display information for cherry." |
| Qualquer outro | "App will display information for unknown fruit." |

## Vantagens do Switch vs If-Else
### Quando Usar Switch
- **Múltiplas condições**: Mais de 2-3 condições
- **Valores específicos**: Comparação com valores fixos
- **Legibilidade**: Código mais limpo e organizado
- **Performance**: Pode ser mais eficiente que if-else

### Sintaxe Comparativa
```csharp
// Com if-else (mais verboso)
if (fruit == "apple")
    Console.WriteLine("App will display information for apple.");
else if (fruit == "banana")
    Console.WriteLine("App wil display information for banana.");
else if (fruit == "cherry")
    Console.WriteLine("App will display information for cherry.");
else
    Console.WriteLine("App will display information for unknown fruit.");

// Com switch (mais limpo)
switch (fruit)
{
    case "apple":
        Console.WriteLine("App will display information for apple.");
        break;
    case "banana":
        Console.WriteLine("App wil display information for banana.");
        break;
    case "cherry":
        Console.WriteLine("App will display information for cherry.");
        break;
    default:
        Console.WriteLine("App will display information for unknown fruit.");
        break;
}
```

## Elementos do Switch
- **Switch expression**: Variável ou expressão a ser testada
- **Case labels**: Valores específicos para correspondência
- **Case bodies**: Código a executar para cada caso
- **Break statements**: Interrompem a execução
- **Default case**: Executado quando nenhum caso corresponde

## Aplicações Práticas
- **Menus de navegação**: Seleção de opções
- **Comandos de usuário**: Processamento de entrada
- **Estados de aplicação**: Controle de fluxo
- **Configurações**: Seleção de parâmetros
- **Validação**: Verificação de tipos e valores

## Importância Educacional
- **Fundamental**: Estrutura essencial em C#
- **Legibilidade**: Código mais organizado
- **Performance**: Alternativa eficiente
- **Manutenibilidade**: Fácil de modificar e extender
- **Boas práticas**: Base para estruturas de controle avançadas
