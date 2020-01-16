using System;
using System.Collections;
using System.Collections.Generic;
namespace Loja
{
    class main
    {
        static void Main(string[] args)
        {

			Livro l1 = new Livro("Harry potter", 40, 50, "J.K.Rolling", "fantasia", 300);
			Livro l2 = new Livro("Senhor dos Aneis", 60, 30, "J.R.R Tolkien", "fantasia", 500);
			Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

			VideoGame game1 = new VideoGame("ps4", 1800, 100, "Sony", "Slim", false);
			VideoGame game2 = new VideoGame("ps4Usado", 1000, 7, "Sony", "Slim", true);
			VideoGame game3 = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

			List<Livro> livros = new List<Livro>();
			livros.Add(l1);
			livros.Add(l2);
			livros.Add(l3);

			List<VideoGame> games = new List<VideoGame>();
			games.Add(game1);
			games.Add(game2);
			games.Add(game3);

			Loja americanas = new Loja("Americanas", "CNPJ 20.794.108-88", livros, games);

			l2.calcularImposto();
			l3.calcularImposto();

			game2.calcularImposto();
			game1.calcularImposto();

			americanas.ListaLivros();
			americanas.ListaVideoGame();
			americanas.calcularPatrimonio();

		}
    }
}
