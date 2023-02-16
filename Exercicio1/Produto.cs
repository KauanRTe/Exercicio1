using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Produto
    {
        private int produtoID;
        private string nome;
        private double valor;
        private int estoque;
        private bool cnpj;

        public int ProdutoID
        {
            get { return produtoID; }
            set { ProdutoID = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { Nome = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int Estoque
        {
            get { return estoque; }
            set { Estoque = value; }
        }

        public bool Cnpj
        {
            get { return cnpj; }
            set { Cnpj = value; }
        }

        public Produto(int produtoID, string nome, double valor, int estoque, bool cnpj)
        {
            this.produtoID = produtoID;
            this.nome = nome;
            this.valor = valor;
            this.estoque = estoque;
            this.cnpj = cnpj;
        }
    }
}
