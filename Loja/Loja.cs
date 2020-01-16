using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja
{
	class Loja
	{   
		private List<Livro> livros;
		private List<VideoGame> videoGames;
		public string  Nome { get; set; }
		public string  Cnpj { get; set; }
		

		public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
		{
			this.Nome = nome;
			this.Cnpj = cnpj;
			this.livros = livros;
			this.videoGames = videoGames;
		}

		public void ListaLivros()
		{
			Console.WriteLine("-----------------------------------------------------------------");
			if (livros.Count == 0)
			{
				Console.WriteLine("Lista vazia");
			}
			else
			{
				Console.WriteLine("A loja americanas possui estes livros para venda: ");
				foreach (Livro elemt in this.livros)
				{
					Console.WriteLine("Titulo: " + elemt.Nome + ", Preço: " + elemt.Preco + ", Quantidade em estoque" + elemt.Qnt);
				}
			}

		}
		public void ListaVideoGame()
		{
			Console.WriteLine("-----------------------------------------------------------------");
			if(videoGames.Count == 0)
			{
				Console.WriteLine("Lista vazia");
			}
			else
			{
					Console.WriteLine("A loja americanas possui estes Video-Games para venda: ");
				foreach (VideoGame elemt in this.videoGames)
				{
					Console.WriteLine("Video-Game: "+ elemt.Nome + ", Preço: " + elemt.Preco + "R$, Quantidade em estoque: "+ elemt.Qnt);
				}
			}
		}
		public void calcularPatrimonio()
		{
			Console.WriteLine("-----------------------------------------------------------------");
			double estoq = 0;
			if(livros.Count == 0)
			{

			}
			else
			{
				foreach (Livro elemt in livros)
				{
					estoq += elemt.Qnt * elemt.Preco;
				}
			}
			if(videoGames.Count == 0)
			{

			}
			else
			{
				foreach (VideoGame elemt in videoGames)
				{
					estoq += elemt.Qnt * elemt.Preco;
				}
			}
			Console.WriteLine("Patrimonio da loja: " + estoq);
		}
	}

}
