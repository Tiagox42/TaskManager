
# Task M️anager 📋
Desenvolvimento de Aplicações: Projeto ASP.NET MVC com CRUDs

![enter image description here](https://i.imgur.com/AUihhhf.gif)

Sistema de gerenciamento de tarefas (to-do list) em uma aplicação web utilizando ASP.NET MVC. 

O sistema permite:

 - Cadastrar uma nova tarefa com título, descrição e data de vencimento.
  - Listar todas as tarefas cadastradas e concluídas separadamente.
   - Atualizar o status das tarefas para concluído. 
   - Excluir tarefas.

## Construção local:
**Requisitos:**
-   MySql 2.1.1
-   [.NET Core 2.1](https://dotnet.microsoft.com/pt-br/download/dotnet/2.1)
- Se possível Microsoft Visual Studio 2019
### Instalar o MySql 2.1 no projeto:
-   Botão direito no nome do projeto -> Manage NuGet Packages
    
-   Na aba Browse, pesquise por: Pomelo.EntityFrameworkCore.MySql
    
-   Clique uma vez no resultado Pomelo.EntityFrameworkCore.Mysql e, na janela ao lado, escolha a versão **2.1.1**
    
-   Clique em Install e conclua a instalação.

Editar a linha TaskManagerContext no arquivo **appsettings.json** do projeto.

"TaskManagerContext": "server=localhost;userid=Usuário;port=3306;password=SuaSenha;database=NomeDoBanco"

Executar os dois seguintes comandos no Console do Gerenciador de Pacotes do Visual Studio:

- Add-Migration Initial
- Update-Database

***Os comandos devem ser executados separadamente.***
