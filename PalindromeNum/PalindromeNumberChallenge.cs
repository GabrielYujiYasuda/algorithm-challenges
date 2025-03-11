namespace PalindromeNum
{
	public class PalindromeNumberChallenge
	{
		public bool Execute(int x)
		{
			//Complexity: O(n)
			if (x < 0) return false;

			var invertedNumber = new string(x.ToString().Reverse().ToArray());

			if (invertedNumber == x.ToString())
				return true;

			return false;

			//Another solution:
			//if (x < 0) return false;

			//var numbered = x.ToString();
			//var newStringNum = "";

			//for (int i = 0; i < numbered.Length; i++)
			//{
			//	for (int j = numbered.Length - 1; j >= 0; j--)
			//	{
			//		newStringNum += numbered[j];
			//	}

			//	break;
			//}

			//if (Equals(newStringNum, numbered))
			//	return true;

			//return false;
		}
	}
}
