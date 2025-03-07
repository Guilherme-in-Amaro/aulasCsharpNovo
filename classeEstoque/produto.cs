using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeEstoque
{
    internal class Produto          //CLASSE
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) //CONSTRUTOR
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double getTotalAmount()      //MÉTODO
        {
            return Preco * Quantidade;
        }
        public string getDetailProduct()    //MÉTODO
        {
            return $"Nome:  {Nome} , Preço:  {Preco} , Quantidade:  {Quantidade}";
        }
    }
}
