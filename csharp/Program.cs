using Biblioteca;

Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis", 3, 2);
Livro livro2 = new Livro("1984", "George Orwell", 5, 2);


livro2.EmprestarLivro();
livro2.EmprestarLivro();
livro2.EmprestarLivro();

livro2.ExibirDetalhes();