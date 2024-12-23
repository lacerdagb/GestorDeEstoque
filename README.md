:package: Gestor de Estoque

:hammer_and_wrench: Projeto de CRUD em C# com POO (Programação Orientada a Objetos)

Bem-vindo ao Gestor de Estoque! :rocket: Este projeto foi desenvolvido em C# e implementa um sistema simples de gerenciamento de estoque utilizando conceitos de Programação Orientada a Objetos (POO).

:clipboard: Funcionalidades

:mag: Listar Produtos - Visualize todos os produtos cadastrados no sistema.

:heavy_plus_sign: Adicionar Produtos - Cadastre produtos físicos, ebooks e cursos.

:x: Remover Produtos - Remova itens do estoque de forma simples.

:inbox_tray: Registrar Entrada - Adicione unidades ao estoque de produtos existentes.

:outbox_tray: Registrar Saída - Diminua unidades do estoque.

:stop_button: Sair do Programa - Finalize o sistema de forma segura.

:jigsaw: Tecnologias Utilizadas

C# - Linguagem de programação principal.

.NET - Framework utilizado para execução do projeto.

POO - Abordagem de Programação Orientada a Objetos.

Serialization - Salva e carrega produtos de forma persistente usando arquivos binários.

:rocket: Como Executar o Projeto

Clone o repositório:

  git clone https://github.com/seuusuario/gestor-de-estoque.git

Abra o projeto em um editor C# (Visual Studio recomendado).

Compile e execute o projeto.

:open_file_folder: Estrutura do Projeto

GestorDeEstoque/
├── Program.cs       # Arquivo principal que contém o fluxo do sistema.
├── ProdutoFisico.cs # Classe que representa produtos físicos.
├── Ebook.cs         # Classe que representa ebooks.
├── Curso.cs         # Classe que representa cursos.
└── produtos.dat     # Arquivo binário para salvar os dados.

:label: Classes e Interfaces

IEstoque - Interface base para produtos.

ProdutoFisico - Implementa produtos físicos com frete.

Ebook - Representa ebooks com autor.

Curso - Cursos online com nome e autor.
