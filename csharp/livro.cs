using System;
using System.Diagnostics.Contracts;

namespace Biblioteca
{
    public class Livro
    {
        public string titulo;
        public string autor;
        private int _numerosDeCopiasDisponiveis;
        private int _totalDeCopias;

        public string getTitulo()
        {
            return this.titulo;
        }

        public string getAutor()
        {
            return this.autor;
        }

        public int getNumerosDeCopiasDisponiveis()
        {
            return this._numerosDeCopiasDisponiveis;
        }
        private void setNumerosDeCopiasDisponiveis(int valor)
        {
            this._numerosDeCopiasDisponiveis = valor;
        }

        public int getTotalDeCopias()
        {
            return this._totalDeCopias;
        }

        private void setTotalDeCopias(int copia)
        {
            this._totalDeCopias = copia;
        }

        public Livro(string Titulo, string Autor, int totalDeCopias, int numeroDeCopias)
        {
            titulo = Titulo;
            autor = Autor;
            _totalDeCopias = totalDeCopias;
            _numerosDeCopiasDisponiveis = numeroDeCopias;
        }

        public void EmprestarLivro()
        {
            if (_numerosDeCopiasDisponiveis > 0)
            {
                _numerosDeCopiasDisponiveis--;
                Console.WriteLine("Uma cópia de " + titulo + " foi emprestada. Número de cópias disponíveis: " + _numerosDeCopiasDisponiveis + ".");
            }
            else
            {
                Console.WriteLine("Não há cópias disponíveis.");
            }
        }

        public void DevolverLivro()
        {
            if (_numerosDeCopiasDisponiveis < _totalDeCopias)
            {
                _numerosDeCopiasDisponiveis++;
                Console.WriteLine("Uma cópia de " + titulo + " foi devolvida. Número de cópias disponíveis: " + _numerosDeCopiasDisponiveis + ".");
            }
            else
            {
                Console.WriteLine("Não há cópias a serem devolvidas.");
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Título: " + this.titulo);
            Console.WriteLine("Autor: " + this.autor);
            Console.WriteLine("Total de Cópias: " + this._totalDeCopias);
            Console.WriteLine("Cópias disponíveis: " + this._numerosDeCopiasDisponiveis);
        }

    }
}
