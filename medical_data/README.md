# medical_data

Este é um pequeno projeto console em C# que demonstra operações com tipos numéricos (int, decimal, float) e conversões.

Pré-requisitos
- .NET SDK 8.0+ instalado (verifique com `dotnet --info`).

Como executar
1. Abra um terminal na pasta do projeto:

   ```bash
   cd /workspaces/c-sharp/medical_data
   ```

2. Restaurar dependências e buildar (opcional, `dotnet run` faz restore automaticamente):

   ```bash
   dotnet build
   ```

3. Executar o programa:

   ```bash
   dotnet run
   ```

Saída esperada
- O programa divide alguns valores e imprime os resultados (um int, um decimal com precisão e um float).

Observações
- Se quiser uma saída decimal formatada com menos casas decimais, edite `Program.cs` e use formatação, por exemplo: `{result2:F2}`.

Contribuições
- Sinta-se à vontade para abrir PRs com melhorias ou exemplos adicionais (structs `Patient`, validação de entrada, leitura/escrita de arquivos, etc.).
