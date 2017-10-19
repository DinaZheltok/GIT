using System;

namespace RandomReplacementOfElements
{
  /// <summary>
  /// This is the entry point of the program.
  /// </summary>
	class EntryPoint
	{
    const string SOURCE = "12345678910";
    const string DESTINATION = "qwertyuiop";

    static void Main(string[] args)
		{
			RandomReplacer randomReplacer = new RandomReplacer(SOURCE, DESTINATION);
			string result = randomReplacer.RandomReplace();
			Console.Write(SOURCE + "\n" + DESTINATION + "\n" + result);
			Console.ReadKey();
		}
	}
}