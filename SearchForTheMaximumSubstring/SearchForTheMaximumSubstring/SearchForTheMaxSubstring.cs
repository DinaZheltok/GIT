using System.Collections.Generic;
using System.Text;

namespace SearchForTheMaximumSubstring
{
  /// <summary>
  /// Сlass, that searches in two strings for a common substring.
  /// </summary>
  class SearchForTheMaxSubstring
  {
    /// <summary>
    /// Method,  that searches in two strings for a common substring.
    /// </summary>
    /// <param name="string1">
    ///  First randomly filled string.
    /// </param>
    /// <param name="string2">
    /// Second randomly filled string.
    /// </param>
    /// <returns>
    /// It returns the common maximum substring.
    /// </returns>
    public string CommonSubstring(string string1, string string2)
    {
      List<string> buffer = new List<string>();
      List<string> result = new List<string>();
      for (int i = 0; i < string1.Length; i++)
      {
        for (int j = 0; j < string2.Length; j++)
        {
          if (string1[i] == string2[j])
          {
            buffer.Add(string1[i].ToString());
            for (int indentation = 1; i + indentation < string1.Length && j + indentation < string2.Length; indentation++)
            {
              if (string1[i + indentation] != string2[j + indentation])
              {
                break;
              }
              buffer.Add(string1[i + indentation].ToString());
            }
            if (buffer.Count > result.Count)
            {
              result.RemoveRange(0, result.Count);
              result = new List<string>(buffer);
            }
            buffer.RemoveRange(0, buffer.Count);
          }
        }
      }
      StringBuilder builder = new StringBuilder();
      foreach (string element in result)
      {
        builder.Append(element);
      }
      string resultString = builder.ToString();
      return resultString;
    }
  }
}