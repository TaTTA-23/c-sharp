# Validação de Função

## Descrição
Programa que demonstra **validação de entrada do usuário** usando loops do-while e métodos de string em C#. O sistema solicita que o usuário digite uma função específica e valida a entrada até que seja fornecida uma opção válida.

## Funcionalidades
- Solicita entrada do usuário para uma das três funções: Administrador, Gerente ou Usuário
- Valida a entrada ignorando diferenças de maiúsculas/minúsculas
- Remove espaços em branco do início e fim da entrada
- Continua solicitando entrada até que uma opção válida seja fornecida
- Confirma a aceitação da entrada válida

## Conceitos Aprendidos
- **Loop do-while**: Garante pelo menos uma execução para validação
- **Métodos de string**: `Trim()` e `ToLower()`
- **Validação de entrada**: Verificação de múltiplas condições
- **Controle de fluxo**: Uso de variáveis booleanas para controle
- **Feedback ao usuário**: Mensagens informativas e de erro

## Como Executar
```bash
cd function-validation
dotnet run
```

## Saída Esperada
```
Digite uma das seguintes funções: Administrador, Gerente ou Usuário.
admin
Função inválida. Digite Administrador, Gerente ou Usuário.
Administrador
Função 'administrador' aceita!
```

## Estrutura do Código
- Classe `ValidacaoFuncao` com método `Main()`
- Variável `funcao` para armazenar a entrada processada
- Variável `funcaoValida` para controlar o loop
- Loop `do-while` para validação contínua
- Condicional `if-else` para verificar validade

## Métodos de String Utilizados
- **`Trim()`**: Remove espaços do início e fim
- **`ToLower()`**: Converte para minúsculas (case-insensitive)
- **`Console.ReadLine()`**: Leitura de entrada do usuário
- **`Console.WriteLine()`**: Exibição de mensagens

## Lógica de Validação
1. Solicita entrada ao usuário
2. Processa a entrada (trim + lowercase)
3. Verifica se é uma das opções válidas
4. Se inválida: exibe erro e continua
5. Se válida: confirma e sai do loop

## Funcionalidades de Validação
- **Case-insensitive**: Aceita "ADMINISTRADOR", "administrador", "Administrador"
- **Espaços ignorados**: Aceita " Administrador ", "Administrador "
- **Feedback imediato**: Informa erros e aceitações
- **Loop robusto**: Continua até entrada válida

## Aplicações Práticas
- Sistemas de autenticação
- Menus interativos
- Validação de formulários
- Sistemas de autorização
- Interfaces de linha de comando
