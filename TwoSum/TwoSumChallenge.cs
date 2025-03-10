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
				for (int j = i; j < nums.Length; j++)
				{
					var sum = nums[j] + nums[i];
					var diffIndex = i != j;

					if (sum == target && diffIndex)
						return [i, j];
				}
			}

			return Array.Empty<int>();
		}
	}
}
