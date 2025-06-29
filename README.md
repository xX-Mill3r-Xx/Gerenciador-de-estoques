---

# 🧾 EstoqueManager

Um sistema desktop de gerenciamento de estoque desenvolvido em **C# com Windows Forms**, utilizando **Dapper** como ORM leve e **SQL Server** como banco de dados.

---

![Interface do Sistema](img/print-interface.png)

---

## 📦 Funcionalidades
- Cadastro e listagem de produtos
- Gerenciamento de entradas e saídas de estoque
- Controle por categorias
- Exibição de relatórios (em breve)
- Interface gráfica responsiva e prática

## 🛠️ Tecnologias utilizadas
- .NET Framework / .NET
- Windows Forms
- Dapper
- SQL Server
- ADO.NET
- Git + GitHub

## 🗂️ Estrutura de pastas

```
/EstoqueManager
│
├── /Forms              # Telas do sistema
├── /Models             # Entidades (Produto, Categoria, etc.)
├── /Controllers        # Camada de controle da aplicação
├── /Data
│   ├── /Repositories   # Repositórios com Dapper
│   └── /Services       # Interfaces
├── /Utils              # Utilitários diversos
├── /Reports            # Relatórios (future)
└── Program.cs
```

## 🧠 Requisitos
- Visual Studio 2022 ou superior
- .NET Framework (ou .NET moderno, se estiver usando .NET 6+)
- SQL Server (local ou remoto)
- Pacote NuGet: `Dapper`

## ⚙️ Como executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/xX-Mill3r-Xx/Gerenciador-de-estoques.git
   ```

2. Crie a base de dados no SQL Server. Deixei um script inicial para a base de dados na pasta Data/Scripts.

3. Configure sua **string de conexão** no arquivo `StringConnection.cs`:

4. Após rodar o script e criar a base de dados, ao iniciar o projeto você será automaticamente direcionado a uma tela de configuração para a base de dados.
   Onde você pode informar o seu servidor e a base de dados criada para rodar este projeto.

5. Restaure os pacotes NuGet e execute o projeto via Visual Studio.

## ✏️ Contribuindo
Contribuições são muito bem-vindas! Abra uma _issue_ ou envie um _pull request_ com suas sugestões ou melhorias.

## 📄 Licença
Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais informações.

---
