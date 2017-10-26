using System;

namespace SearchForTheMaximumSubstring
{
  /// <summary>
  /// Сlass, that contains a method for randomly filling strings.
  /// </summary>
  class RandomFillingOfStrings
  {
    Random rand = new Random();
    public string RandomFillingString()
    {
      string alphabet = "abcdefghijklmnopqrstuvwxyz";
      int length = 40;
      char[] randomArray = new char[length];
      for (int i = 0; i < length; i++)
      {
        int randIndex = rand.Next(alphabet.Length);
        randomArray[i] = alphabet[randIndex];
      }
      string randomString = new string(randomArray);
      return randomString;
    }
  }
}