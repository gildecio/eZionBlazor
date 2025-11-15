# eZionBlazor — Guia de Execução

## Requisitos
- Node.js (18+ recomendado) e `npm`
- .NET SDK 6.0

## Instalação
1. Instale as dependências do frontend:
   ```
   npm install
   ```
2. (Opcional) Atualize a base de dados do Browserslist para evitar avisos:
   ```
   npx update-browserslist-db@latest
   ```

## Desenvolvimento
- Compile o CSS do Tailwind continuamente em um terminal:
  ```
  npm run watch:css
  ```
- Inicie o servidor Blazor em outro terminal:
  ```
  dotnet run
  ```
- O projeto usa tema escuro por padrão (DaisyUI). Para trocar o tema, ajuste `data-theme` no elemento `<html>` em `Pages/_Layout.cshtml`.

## Build
- A compilação .NET chama a geração do CSS (Tailwind) automaticamente via alvo MSBuild do projeto:
  ```
  dotnet build
  ```
- O CSS gerado fica em `wwwroot/css/tailwind.css`.

## Scripts disponíveis
- `npm run build:css` — compila o CSS uma vez (minificado)
- `npm run watch:css` — compila o CSS e observa mudanças

## Observações
- O projeto está focado em frontend (sem banco) e usa Tailwind + DaisyUI. Bootstrap e MudBlazor foram removidos.
- Endereços padrão de execução (conforme `Properties/launchSettings.json`):
  - `https://localhost:7023`
  - `http://localhost:5230`