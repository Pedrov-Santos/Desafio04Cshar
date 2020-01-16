using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    abstract class Produto
    {
		protected string nome;
		protected double preco;
		protected int qnt;
		public string Nome { set; get; }
		public double Preco { set; get; }
		public int Qnt { set; get; }

		public Produto(string nome, double preco, int qnt)
		{

			this.Nome = nome;
			this.Preco = preco;
			this.Qnt = qnt;
		}
	}
}
