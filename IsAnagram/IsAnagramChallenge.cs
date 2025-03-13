namespace IsAnagram
{
	class IsAnagramChallenge
	{
		public bool Execute(string s, string t)
		{
			var sSize = s.Length;
			var tSize = t.Length;

			var letterCount = 0;

			if (sSize != tSize)
				return false;

			for (int i = 0; i < s.Length; i++)
			{
				for (int j = 0; j < s.Length; j++)
				{
					if (s[i].Equals(s[j]))
					{
						letterCount++;
					}
				}
			}

			if (letterCount == sSize)
				return true;

			return false;
		}
	}
}
