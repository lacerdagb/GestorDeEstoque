# 📋 Gestor de Estoque em C#

Um simples programa de gerenciamento de estoque feito em **C#**, com funcionalidades de adicionar, listar, remover e movimentar produtos. Os dados são salvos em um arquivo para garantir persistência entre execuções. 

Este projeto é um **CRUD** (Create, Read, Update, Delete) básico para gerenciamento de estoque, utilizando conceitos de **Programação Orientada a Objetos (POO)**.

---

## 🚀 **Funcionalidades**

- 📄 **Listar Produtos**: Visualize todos os produtos cadastrados.
- ➕ **Adicionar Produtos**: Cadastre produtos físicos, ebooks e cursos.
- 🗑️ **Remover Produtos**: Apague um produto pelo seu **ID**.
- 📥 **Registrar Entrada**: Adicione unidades ao estoque de produtos existentes.
- 📤 **Registrar Saída**: Diminua unidades do estoque.
- 💾 **Persistência de Dados**: Os dados são salvos em um arquivo binário (**produtos.dat**) para que não se percam quando o programa é fechado.

---

## 🛠️ **Como Executar o Projeto**

1. **Clone o repositório**:

   ```bash
   git clone https://github.com/lacerdagb/gestor-de-estoque.git
   
   ```

2. **Abra o projeto no Visual Studio** ou qualquer outro editor de sua preferência.

3. **Compile e execute** o projeto:

   ```bash
   dotnet run
   ```

---

## 🖥️ **Uso do Programa**

Quando executar o programa, o seguinte menu será exibido:

```plaintext
Sistema de estoque:
1-Listar
2-Adicionar
3-Remover
4-Registrar entrada
5-Registrar saída
6-Sair
```

### 📄 **1. Listar Produtos**

Exibe todos os produtos cadastrados com **ID** e detalhes específicos do produto.

### ➕ **2. Adicionar Produtos**

Solicita as informações do produto e o cadastra no sistema. É possível adicionar produtos físicos, ebooks ou cursos.

### 🗑️ **3. Remover Produtos**

Permite excluir um produto informando seu **ID**.

### 📥 **4. Registrar Entrada**

Adiciona mais unidades ao estoque de um produto.

### 📤 **5. Registrar Saída**

Diminui unidades do estoque de um produto.

### 🚪 **6. Sair**

Salva os dados e encerra o programa.

---

## 📂 **Estrutura do Projeto**

```
GestorDeEstoque/
├── Program.cs       # Arquivo principal que contém o fluxo do sistema.
├── ProdutoFisico.cs # Classe que representa produtos físicos.
├── Ebook.cs         # Classe que representa ebooks.
├── Curso.cs         # Classe que representa cursos.
└── produtos.dat     # Arquivo binário para salvar os dados.
```

---

## 📜 **Licença**

Este projeto está licenciado sob a **MIT License**.

---

## 🤝 **Contribuições**

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma **issue** ou enviar um **pull request**. 

---

## 📞 **Contato**

- **LinkedIn**: (www.linkedin.com/in/gabriel-lacerda-052a8a293/)
- **Email**: gblacerda15@gmail.com


