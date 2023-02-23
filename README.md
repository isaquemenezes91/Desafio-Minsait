# Desafio Minsait
## Projeto de desenvolvimento de uma API em .NET para o desafio técnico da minsait, para vaga de Jovens Profissionais.

Aplicação em .NET 6 para desenvolvimento de uma API

### Requisitos necessários:
- Criar
- Editar
- Excluir
- Buscar
- Validação de Livros ja cadastrado (titulo, subtitulo, e edição validam essa condição)
- Acesso ao banco de dados


## Breve descrição da aplicação
Projeto desenvolvido para gerenciar os livros de uma livraria, onde será cadastrado o livro e o autor


# Executando projeto localmente
## Pré-requisitos
- <a href="https://visualstudio.microsoft.com/pt-br/downloads/">Visual Studio</a>
- <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads">SQL SERVER</a>


## Configuração

1. Agora tem-se que alterar no arquivo "appsettings.json" a connection string
```
"ConnectionStrings": {
    "DataBase": "Server={Seu Server};Database=LivrariaDataBase;Persist Security Info=True;TrustServerCertificate=True;User Id={seu user};Password={sua senha}"
  }
```  
2. Agora basta rodar o projeto no Visual Studio normalmente

