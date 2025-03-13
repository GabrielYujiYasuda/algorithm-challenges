namespace MaxCount
{
	class MaxCountChallenge
	{
		public int Execute(int[] nums)
		{
			var numberOfNegative = 0;
			var numberOfPositive = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] < 0)
					numberOfNegative++;

				if (nums[i] > 0)
					numberOfPositive++;
			}

			var isPositiveHigher = numberOfPositive > numberOfNegative;

			if (isPositiveHigher)
				return numberOfPositive;

			return numberOfNegative;
		}
	}
}
