using RoverChallenge;
using System;

namespace RoverChallengeConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var posicao = "1 2 N";
			var instrucoes = "LMLMLMLMM";

			var rover = new Rover();
			var resultado = rover.ObterPosicao(instrucoes, posicao);

			Console.WriteLine(resultado);
			Console.ReadLine();
		}
	}
}
