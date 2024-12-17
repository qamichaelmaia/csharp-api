# Projeto de API em C# ASP.Net Core

Este projeto implementa uma API com duas funcionalidades principais: cadastro de usuários e de carteiras. A solução foi construída utilizando C# e ASP.Net Core, seguindo a arquitetura de camadas (API, Services e Repository), e conecta-se a um banco de dados SQL Server local para persistência dos dados.

## Estrutura do Projeto

A arquitetura do projeto está dividida em três camadas principais:

1. **API / Controllers**: Contém os controladores que expõem as APIs para interação com o usuário.
2. **Services**: Contém a lógica de negócio.
3. **Repository**: Realiza a comunicação com o banco de dados, utilizando Entity Framework Core.

### Entidades

O projeto possui as seguintes entidades:

- **User**
  - `ID`: Identificador único do usuário.
  - `Nome`: Nome completo do usuário.
  - `Nascimento`: Data de nascimento do usuário.
  - `CPF`: CPF do usuário.

- **Wallet**
  - `ID`: Identificador único da carteira.
  - `UserID`: Relacionamento com o usuário (chave estrangeira).
  - `ValorAtual`: Valor atual disponível na carteira.
  - `Banco`: Nome do banco associado à carteira.
  - `UltimaAtualizacao`: Data da última atualização da carteira.

### Funcionalidades

O projeto implementa duas APIs principais:

- **UserController**
  - **POST /users**: Cadastra um novo usuário.

- **WalletController**
  - **POST /wallets**: Cadastra uma nova carteira para um usuário.
  - **GET /wallets/{userId}**: Obtém a lista de carteiras associadas a um usuário.

## Banco de Dados

O projeto utiliza o **SQL Server** como banco de dados. A base de dados deve ser criada localmente, e a conexão é realizada via Entity Framework Core.

