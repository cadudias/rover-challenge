using NUnit.Framework;
using RoverChallenge;

namespace Tests
{
	public class Tests
	{
		[TestCase("RRRR", 'N', 'N')]
		[TestCase("RRR", 'S', 'W')]
		[TestCase("R", 'N', 'W')]
		[TestCase("LLLL", 'N', 'N')]
		[TestCase("LLLLLLLL", 'N', 'N')]
		[TestCase("L", 'N', 'E')]
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