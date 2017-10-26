using System;

namespace SearchForTheMaximumSubstring
{
  /// <summary>
  /// This is the entry point of the programm 
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      RandomFillingOfStrings rand = new RandomFillingOfStrings();
      string string1 = rand.RandomFillingString();
      string string2 = rand.RandomFillingString();
      Console.Write("First string:  " + string1 + "\nSecond string: " + string2);
      SearchForTheMaxSubstring search = new SearchForTheMaxSubstring();
      string resultString = search.CommonSubstring(string1, string2);
      Console.Write("\nCommon substring: " + resultString);
      Console.ReadKey(true);
    }
  }
}