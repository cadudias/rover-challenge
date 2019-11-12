using System;

namespace RoverChallenge
{
	public class Rover
	{
		public char[] pontosCardeais = new char[] { 'N', 'E', 'S', 'W' };

		public string ObterPosicao(string instrucoes, string posicaoAtual)
		{
			var posicoes = posicaoAtual.Replace(" ", "").ToCharArray();
			var coordenadaX = posicoes[0];
			var coordenadaY = posicoes[1];
			var pontoCardealAtual = posicoes[2];

			for (int i = 0; i < instrucoes.Length; i++)
			{
				if (instrucoes[i] == 'R' || instrucoes[i] == 'L')
					pontoCardealAtual = AtualizarPontoCardeal(instrucoes[i], pontoCardealAtual);
				else
				{
					switch (pontoCardealAtual)
					{
						case 'N':
							coordenadaY++;
							break;
						case 'S':
							coordenadaY--;
							break;
						case 'E':
							coordenadaX++;
							break;
						case 'W':
							coordenadaX--;
							break;
					}
				}
			}

			return $"{coordenadaX} {coordenadaY} {pontoCardealAtual}";
		}

		public char AtualizarPontoCardeal(char direcao, char pontoCardealAtual)
		{
			var indicePontoCardealAtual = Array.IndexOf(pontosCardeais, pontoCardealAtual);

			if (direcao == 'R')
			{
				indicePontoCardealAtual++;

				if (indicePontoCardealAtual == pontosCardeais.Length)
					indicePontoCardealAtual = 0;
			}
			else
			{
				if (indicePontoCardealAtual == 0)
					indicePontoCardealAtual = pontosCardeais.Length - 1;
				else
					indicePontoCardealAtual--;
			}

			return (char)pontosCardeais.GetValue(indicePontoCardealAtual);
		}
	}
}
