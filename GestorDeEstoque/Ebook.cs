using System;

namespace GestorDeEstoque
{
    [Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
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
            Console.WriteLine($"Vendas : {vendas}");
            Console.WriteLine("=========================");
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é oissível dar entrada no estoque de um E-book pois é um arquivo digital!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {

        }
    }
}
