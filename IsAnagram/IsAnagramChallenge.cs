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


			var sArr = s.ToArray();
			var tArr = t.ToArray();

			Array.Sort(sArr);
			Array.Sort(tArr);

			for (int i = 0; i < sArr.Length; i++)
			{
				if (sArr[i].Equals(tArr[i]))
					letterCount++;
			}


			if (letterCount == sArr.Length)
				return true;

			return false;
		}
	}
}
