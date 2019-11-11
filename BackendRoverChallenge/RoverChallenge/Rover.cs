using System;
using System.Collections.Generic;

namespace RoverChallenge
{
	public class Rover
	{
		public char[] pontosCardeais = new char[] { 'N', 'E', 'S', 'W' };

		public string ObterPosicao(string instrucoes, string posicaoAtual)
		{
			instrucoes = "LMLMLMLMM";
			posicaoAtual = "1 2 N";
			var posicoes = posicaoAtual.Trim().ToCharArray();
			var coordenadaX = posicoes[0];
			var coordenadaY = posicoes[1];
			var pontoCardealAtual = posicoes[2];

			for (int i = 0; i < instrucoes.Length; i++)
			{
				// se for L ou R
				if (instrucoes[i] == 'R' || instrucoes[i] == 'L')
				{
					// chama o metodo que pontoCardealAtual = AtualizaPontoCardeal(intrucao, pontoCardealAtual)
					pontoCardealAtual = AtualizarPontoCardeal(instrucoes[i], pontoCardealAtual);

					// se for M chama o metodo que move a rover
					// se for N 
					// move 1 ponto no eixo Y
					// pra mover tem que pegar as coordenadas dos pontos x e y
					// ex: se for 1 2 dqar um split no ' '
					// pegar a coordenadaX e somar 1 - coordenadaX++
					// se for S
					// move -1 ponto no eixo Y
					// pra mover tem que pegar as coordenadas dos pontos x e y
					// ex: se for 1 2 dqar um split no ' '
					// pegar a coordenadaY e diminuir 1 - coordenadaY--
					// se for W
					// move -1 ponto no eixo X
					// se for E
					// move 1 ponto no eixo X
				}
			}




		}

		/*
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
		*/

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
