# 🐾 Petfolio API

Este repositório contém o código-fonte do **Petfolio API**, um backend desenvolvido para gerenciar um portfólio de animais de estimação. A API permite realizar operações de **CRUD** (Criar, Ler, Atualizar e Deletar) para pets.

---

## ✨ Principais Funcionalidades

- **Adicionar novos pets**: Permite o registro de novos animais no sistema.
- **Listar todos os pets**: Retorna uma lista com informações resumidas de todos os pets cadastrados.
- **Obter um pet por ID**: Busca e exibe os detalhes de um animal específico.
- **Atualizar informações**: Permite modificar os dados de um pet já existente.
- **Remover um pet**: Exclui o registro de um animal do sistema.

---

## 🛠️ Tecnologias e Linguagens Utilizadas

- **C#**: Linguagem de programação principal.
- **.NET**: Plataforma de desenvolvimento da Microsoft (.NET 6, 7 ou 8).
- **ASP.NET Core Web API**: Framework para construção de APIs RESTful.
- **Swagger (Swashbuckle)**: Para documentação e teste interativo dos endpoints da API.
- **Arquitetura baseada em Casos de Uso (Use Cases)**: Separação entre regras de negócio e controllers.

---

## 📚 Endpoints da API

| Método | Rota        | Descrição                                 |
|--------|-------------|-------------------------------------------|
| POST   | `/pet`      | Registra um novo pet no sistema.          |
| GET    | `/pets`     | Retorna a lista de todos os pets.         |
| GET    | `/pet/{id}` | Busca um pet específico pelo seu ID.      |
| PUT    | `/pet/{id}` | Atualiza os dados de um pet específico.   |
| DELETE | `/pet/{id}` | Deleta o registro de um pet específico.   |

---

## 🚀 Como Executar o Projeto

### ✅ Pré-requisitos

- [.NET SDK (6 ou superior)](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)

### 💻 Passos

```bash
# Clone o repositório
git clone https://github.com/raphaelscosta/petfolio-api.git

# Acesse a pasta do projeto
cd petfolio-api

# Restaure as dependências
dotnet restore

# Execute o projeto
dotnet run
