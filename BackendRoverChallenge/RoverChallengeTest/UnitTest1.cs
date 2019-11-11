using NUnit.Framework;
using RoverChallenge;

namespace Tests
{
	public class Tests
	{
		[TestCase("RRRR", 'N', 'N')]
		[TestCase("RRR", 'S', 'E')]
		[TestCase("R", 'N', 'E')]
		[TestCase("LLLL", 'N', 'N')]
		[TestCase("LLLLLLLL", 'N', 'N')]
		[TestCase("L", 'N', 'W')]
		public void ObterPontoCardealAtualFinal(
			string instrucoes, 
			char pontoCardealAtual, 
			char resultadoEsperado)
		{
			var rover = new Rover();
			var resultado = rover.ObterPontoCardealFinal(instrucoes, pontoCardealAtual);
			Assert.AreEqual(resultadoEsperado, resultado);
		}
	}
}