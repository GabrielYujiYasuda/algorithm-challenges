namespace LastWordLenght
{
	public class LastWordLenghtChallenge
	{
		public int Execute(string s)
		{
			string[] words = s.Trim().Split(" ");

			var lastIndex = words.Length - 1;
			var lastWord = words[lastIndex];

			return lastWord.Length;
		}
	}
}
