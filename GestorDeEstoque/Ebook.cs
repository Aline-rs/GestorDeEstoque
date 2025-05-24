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
            Console.WriteLine("Não é possível dar entrada no estoque de um E-book pois é um arquivo digital!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar venda no E-book {nome}");
            Console.WriteLine("Digite a quantidade que você quer dar entrada: ");
            int saida = int.Parse(Console.ReadLine());
            vendas += saida;
            Console.WriteLine("Venda registrada!");
            Console.ReadLine();
        }
    }
}
