using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoque
{
    internal class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("=========================");
        }

        public void AdicionarEntrada()
        {

        }

        public void AdicionarSaida()
        {

        }
    }
}
