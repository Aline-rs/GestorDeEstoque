using System;
using System.Collections.Generic;

namespace GestorDeEstoque
{
    internal class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("Sistema de Estoque");
                Console.WriteLine();
                Console.WriteLine("1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Entrada\n5 - Saida\n6 - Sair");
                string opStr = Console.ReadLine();
                int opInt = int.Parse(opStr);

                Menu escolha = (Menu)opInt;

                if (opInt > 0 && opInt < 7)
                {
                    switch (escolha)
                    {
                        case Menu.Listar:
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            break;
                        case Menu.Entrada:
                            break;
                        case Menu.Saida:
                            break;
                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
                Console.Clear();
            }

        }

        static void Cadastro()
        {
            Console.WriteLine("Cadastro de Produto");
            Console.WriteLine("1 - Produto Fisico\n2 - Ebook\n3 - Curso");
            string opStr = Console.ReadLine();
            int escolhaInt = int.Parse(opStr);
            switch (escolhaInt)
            {
                case 1:
                    CadastroPFisico();
                    break;
                case 2:
                    CadastroEbook();
                    break;
                case 3:
                    CadastroCurso();
                    break;
            }
        }

        static void CadastroPFisico()
        {
            Console.WriteLine("Cadastrando produto físico: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.Write("Frete: ");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
        }

        static void CadastroEbook()
        {
            Console.WriteLine("Cadastrando ebook: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Ebook eb = new Ebook(nome, preco, autor);
            produtos.Add(eb);
        }

        static void CadastroCurso()
        {
            Console.WriteLine("Cadastrando curso: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Curso cs = new Curso(nome, preco, autor);
            produtos.Add(cs);
        }
    }
}
