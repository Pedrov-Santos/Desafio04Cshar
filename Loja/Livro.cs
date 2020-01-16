using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
	class Livro : Produto, Imposto
	{
		
		public string Autor { set; get; }
		public string Tema { set; get; }
		public int QntPag { set; get; }

		public Livro(string nome, double preco, int qnt, string autor, string tema, int qntPag) :
			base(nome, preco, qnt)
		{

			this.Autor = autor;
			this.Tema = tema;
			this.QntPag = qntPag;
		}
			public double imp { get; set; }
		public double calcularImposto()
		{
			if (this.Tema == "educativo")
			{
				Console.WriteLine("Livro educativo não possui impostos: " + this.Nome);
				return 0;
			}
			else
			{
				imp = this.Preco * 0.1;
				Console.WriteLine("O imposto do livro, " + this.Nome + " é de: R$ " + imp);
				return imp;
			}


		}
	}
}