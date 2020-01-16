using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
	class VideoGame : Produto, Imposto
	{
		public String Marca { set; get; }
		public String Modelo { set; get; }
		public Boolean IsUsado { set; get; }



		public VideoGame(String nome, double preco, int qnt, String marca, String modelo, Boolean isUsado) :
			base(nome, preco, qnt) 
		{
			this.Marca = marca;
			this.Modelo = modelo;
			this.IsUsado = isUsado;
		}

		public double calcularImposto()
		{
			
			if (this.IsUsado == true)
			{
				
				Console.WriteLine("Imposto: " + this.Nome + " " + this.Modelo + " R$ " + this.Preco*0.25);
				return this.Preco*0.25;

			}
			else
			{
				
				Console.WriteLine("Imposto: " + this.Nome + " " + this.Modelo + " R$ " + this.Preco*0.45);
				return this.Preco*0.45;
			}
		}
	}	

}
