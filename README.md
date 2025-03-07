# ASP-NET-Core-TodoApp

Este é um projeto pessoal de estudo voltado ao domínio dos fundamentos do desenvolvimento web utilizando ASP.NET. O foco está na implementação prática das operações CRUD (Create, Read, Update, Delete) de forma simplificada.

## Sobre o Projeto

A aplicação consiste em um gerenciador de tarefas (Todo List) que demonstra conceitos essenciais do ASP.NET Core através de uma interface simples e funcional. O projeto serve como um laboratório prático para explorar e compreender os mecanismos fundamentais do desenvolvimento web com .NET.

## Funcionalidades

- Listar todas as tarefas
- Adicionar novas tarefas
- Editar tarefas existentes
- Excluir tarefas
- Marcar tarefas como concluídas/pendentes

## Tecnologias Utilizadas

- ASP.NET Core 8.0
- Entity Framework Core
- SQLite
- Razor Pages
- Bootstrap 5

## Pré-requisitos

- .NET SDK 8.0 ou superior

## Como Executar

1. Clone o repositório:
   ```
   git clone https://github.com/seu-usuario/ASP-NET-Core-TodoApp.git
   cd ASP-NET-Core-TodoApp
   cd TodoApp
   ```

2. Execute a aplicação:
   ```
   dotnet run
   ```

3. Abra seu navegador e acesse:
   ```
   https://localhost:5001
   ```

## Estrutura do Projeto

- `Models/`: Contém as classes de modelo
- `Data/`: Contém o contexto do Entity Framework Core
- `Pages/`: Contém as páginas Razor
- `wwwroot/`: Contém arquivos estáticos (CSS, JS, imagens)

## Conceitos Demonstrados

- Razor Pages
- Entity Framework Core
- Injeção de Dependência
- Data Binding
- CRUD Operations
- SQLite Integration

## Objetivos de Aprendizado

Este projeto foi criado com a finalidade de:
- Compreender a estrutura básica de uma aplicação ASP.NET Core
- Praticar o desenvolvimento de interfaces usando Razor Pages
- Entender o funcionamento do Entity Framework Core com um banco de dados simples
- Implementar e testar operações CRUD em um ambiente controlado
- Explorar padrões de design comuns em aplicações web modernas
