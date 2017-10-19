using System;

namespace RandomReplacementOfElements
{
	class Program
	{
		static void Main(string[] args)
		{
			string source = "12345678910";
			string destination = "qwertyuiop";

			RandomReplacer randomReplacer = new RandomReplacer(source, destination);
			string result = randomReplacer.RandomReplace();
			Console.Write(source + "\n" + destination + "\n" + result);
			Console.ReadKey();
		}
	}
}
