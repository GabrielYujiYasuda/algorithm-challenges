namespace LCP
{
	public class LongestCommon
	{
		public string Execute(string[] strs)
		{
			string res = "";

			for (int i = 0; i < strs[0].Length; i++)
			{
				char currentChar = strs[0][i];

				foreach (string s in strs)
				{
					if (i >= s.Length || s[i] != currentChar)
						return res;
				}

				res += currentChar;
			}

			return res;
		}
	}
}

