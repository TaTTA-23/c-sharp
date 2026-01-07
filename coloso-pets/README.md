# Coloso Pets - Sistema de Gerenciamento de Animais

## Descrição
Aplicação completa para gerenciamento de animais de estimação em um abrigo. O sistema permite cadastrar, listar e gerenciar informações de cães e gatos.

## Funcionalidades
- **Listagem de animais**: Exibe todos os animais cadastrados com informações completas
- **Cadastro de animais**: Interface para adicionar novos animais (placeholder)
- **Validação de dados**: Sistema para completar informações faltantes
- **Busca por características**: Filtros para encontrar animais específicos
- **Menu interativo**: Interface amigável com opções numeradas

## Estrutura de Dados
Cada animal armazena:
- **ID**: Identificador único
- **Espécie**: Cão ou Gato
- **Idade**: Idade do animal
- **Apelido**: Nome pelo qual é conhecido
- **Descrição física**: Características físicas detalhadas
- **Personalidade**: Descrição comportamental

## Como Executar
```bash
cd coloso-pets
dotnet run
```

## Menu Principal
```
1. List all of our current pet information
2. Add a new animal friend to the ourAnimals array
3. Ensure animal ages and physical descriptions are complete
4. Ensure animal nicknames and personality descriptions are complete
5. Edit an animal's age
6. Edit an animal's personality description
7. Display all cats with a specified characteristic
8. Display all dogs with a specified characteristic
```

## Animais Pré-cadastrados
- **Lola**: Fêmea golden retriever, 2 anos, gosta de ter a barriga friccionada
- **Loki**: Macho golden retriever, 9 anos, gosta de receber carinho nas orelhas
- **Puss**: Fêmea branca, 1 ano, personalidade amigável
- **Animal 4**: Cadastro incompleto (placeholder para novos animais)

## Conceitos Demonstrados
- **Arrays bidimensionais**: Armazenamento de dados tabulares
- **Switch statements**: Alternativa aos if-elseif-else
- **Menu systems**: Interface de linha de comando estruturada
- **Data validation**: Verificação de completude de dados
- **String manipulation**: Processamento de strings e interpolação

## Status de Desenvolvimento
- ✅ **Implementado**: Listagem de animais, menu principal, estrutura de dados
- 🔄 **Placeholder**: Funcionalidades 2-8 (ainda não implementadas)
- 📋 **Próximos passos**: Implementar funcionalidades de cadastro e edição

## Arquitetura
- **Classe única**: Todo o código em uma classe principal
- **Loop principal**: While loop para manter o programa ativo
- **Switch menu**: Controle de fluxo baseado na seleção do usuário
- **Arrays dinâmicos**: Estrutura flexível para armazenar dados
