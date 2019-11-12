using NUnit.Framework;
using RoverChallenge;

namespace RoverChallengeTest
{
	public class RoverTest
	{
		[TestCase('R', 'N', 'E')]
		[TestCase('L', 'N', 'W')]
		[TestCase('L', 'E', 'N')]
		public void DadaUmaDirecao_AtualizarPontoCardeal(
			char instrucao,
			char pontoCardealAtual,
			char resultadoEsperado)
		{
			var rover = new Rover();
			var resultado = rover.AtualizarPontoCardeal(instrucao, pontoCardealAtual);
			Assert.AreEqual(resultadoEsperado, resultado);
		}

		[TestCase("1 2 N", "LMLMLMLMM", "1 3 N")]
		[TestCase("3 3 E", "MMRMMRMRRM", "5 1 E")]
		public void DadasInstrucoes_ObterPosicaoDaRover(
			string posicaoAtual,
			string instrucoes,
			string resultadoEsperado)
		{
			var rover = new Rover();
			var resultado = rover.ObterPosicao(instrucoes, posicaoAtual);
			Assert.AreEqual(resultadoEsperado, resultado);
		}
	}
}
