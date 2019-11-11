using NUnit.Framework;
using RoverChallenge;

namespace Tests
{
	public class Tests
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
	}
}
