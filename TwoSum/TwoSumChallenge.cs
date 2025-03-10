namespace TwoSum
{
	public class TwoSumChallenge
	{
		//Complexity:  O(n²)
		// due to nested loops
		public int[] Execute(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = 1; j < nums.Length; j++)
				{
					var sum = nums[i] + nums[j];

					if (sum == target)
						return [i, j];
				}
			}

			return Array.Empty<int>();
		}
	}
}
