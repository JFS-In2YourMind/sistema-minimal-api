# Sistema Minimal API - DIO

Projeto desenvolvido como parte do curso da DIO sobre **Minimal APIs com .NET**, com o objetivo de aprender os conceitos básicos de construção de APIs leves e rápidas utilizando o .NET 6+.

##  Descrição

Este projeto simula um controle de tarefas (To-Do List), utilizando recursos de Minimal API, como:

- Criação de rotas HTTP (`GET`, `POST`, `PUT`, `DELETE`);
- Registro de dados em memória;
- Mapeamento direto de endpoints com lambdas;
- Boas práticas de organização em projetos .NET.

---

##  Tecnologias Utilizadas

- .NET 6+
- Minimal API
- C#
- Visual Studio Code / Visual Studio
- Swagger (opcional)

---

##  Funcionalidades

| Método | Rota           | Descrição                           |
|--------|----------------|-------------------------------------|
| GET    | `/todos`       | Retorna todos os itens cadastrados |
| GET    | `/todos/{id}`  | Retorna um item específico pelo ID |
| POST   | `/todos`       | Cria um novo item                  |
| PUT    | `/todos/{id}`  | Atualiza um item existente         |
| DELETE | `/todos/{id}`  | Remove um item                     |

---

##  Como executar

1. Clone o repositório:

```bash
git clone https://github.com/JFS-In2YourMind/sistema-minimal-api.git
cd sistema-minimal-api
```

2. Execute o projeto:

```bash
dotnet run
```

3. A API ficará disponível em:

```
http://localhost:5152
```

Você pode testar as rotas utilizando Postman, Insomnia ou via navegador.

---

##  Exemplo de Requisição (POST)

```json
POST /todos

{
  "id": 1,
  "title": "Estudar Minimal API",
  "done": false
}
```

---

##  Créditos

Projeto desenvolvido como parte do curso da [Digital Innovation One](https://www.dio.me/) na trilha **.NET Start**.

FEITO POR JAQUELINE FELIX
