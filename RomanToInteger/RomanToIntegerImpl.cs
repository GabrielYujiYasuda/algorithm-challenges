namespace RomanToInteger
{
	public class RomanToIntegerImpl
	{
		// I can be placed before V(5) and X(10) to make 4 and 9. 
		// X can be placed before L(50) and C(100) to make 40 and 90. 
		// C can be placed before D(500) and M(1000) to make 400 and 900.
		public int Execute(string s)
		{
			//Input: MCMXCIV
			var totalSum = 0;
			
			var dict = new Dictionary<char, int>
			{
				{ 'I', 1 },
				{ 'V', 5 },
				{ 'X', 10 },
				{ 'L', 50 },
				{ 'C', 100 },
				{ 'D', 500 },
				{ 'M', 1000 },
			};

			for (int i = 0; i < s.Length; i++)
			{
				if (i < s.Length - 1 && dict[s[i]] < dict[s[i + 1]])
					totalSum -= dict[s[i]];
				else
					totalSum += dict[s[i]];
			}

			return totalSum;
		}
	}
}
