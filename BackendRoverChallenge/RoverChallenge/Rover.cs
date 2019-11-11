using System;

namespace RoverChallenge
{
	public class Rover
	{
		public char[] pontosCardeais = new char[] { 'N', 'E', 'S', 'W' };

		public char ObterPontoCardealFinal(string direcoes, char pontoCardealAtual)
		{
			var indicePontoCardealAtual = Array.IndexOf(pontosCardeais, pontoCardealAtual);

			for (var i = 0; i < direcoes.Length; i++)
			{
				if (direcoes[i] == 'R')
				{
					indicePontoCardealAtual++;

					if (indicePontoCardealAtual == pontosCardeais.Length)
						indicePontoCardealAtual = 0;
				}
				else {
					if (indicePontoCardealAtual == 0)
						indicePontoCardealAtual = pontosCardeais.Length - 1;
					else
						indicePontoCardealAtual--;
				}
			}
			return (char)pontosCardeais.GetValue(indicePontoCardealAtual);
		}
	}
}
