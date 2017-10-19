using System;

namespace RandomReplacementOfElements
{
  /// <summary>
  /// This class is used to randomly replace elements from one string to another.
  /// </summary>
	class RandomReplacer
	{
		public string SourceString { get; set; }
		public string DestinationString { get; set; }
		Random rand = new Random();
    
		public RandomReplacer(string sourceString,string destinationString)
		{
			SourceString = sourceString;
			DestinationString = destinationString;
		}

		public int SearchIndexFromStringSource()
		{
			return rand.Next(SourceString.Length);
		}

		public int SearchIndexFromStringDestination()
		{
			return rand.Next(DestinationString.Length);
		}

		public int GetLengthOfPieceFromStringSource(int sourceIndex)
		{
			return rand.Next(1, SourceString.Length - sourceIndex);
		}

		public int GetLengthOfPieceFromStringDestination( int destinationIndex)
		{
			return rand.Next(1, DestinationString.Length - destinationIndex);
		}

		public string GetPieceFromString( int sourceIndex, int sizeOfPiece)
		{
			return SourceString.Substring(sourceIndex, sizeOfPiece);
		}

    /// <summary>
    /// Using the methods implemented above,this method is used to randomly replace elements from one string to another.
    /// </summary>
    /// <returns>
    /// This method return new string with with a randomly-replaced sequence of elements.
    /// </returns>
		public string RandomReplace()
		{
			int startIndexSource = SearchIndexFromStringSource();
			int sizeOfPieceFromStringSource = GetLengthOfPieceFromStringSource(startIndexSource);
			string pieceFromStringSource = GetPieceFromString(startIndexSource, sizeOfPieceFromStringSource);
			int startIndexDestination = SearchIndexFromStringDestination();
			int sizeOfPieceFromStringDestination = GetLengthOfPieceFromStringDestination(startIndexDestination);
			string result = DestinationString.Remove(startIndexDestination, sizeOfPieceFromStringDestination);
			result = result.Insert(startIndexDestination, pieceFromStringSource);
			return result;
		}
	}
}