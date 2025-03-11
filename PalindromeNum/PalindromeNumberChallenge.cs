namespace PalindromeNum
{
	public class PalindromeNumberChallenge
	{
		public bool Execute(int x)
		{
			if (x < 0) return false;

			var invertedNumber = new string(x.ToString().Reverse().ToArray());

			if (invertedNumber == x.ToString())
				return true;

			return false;
		}
	}
}
