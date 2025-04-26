internal class Program
{
	private static void Main(string[] args)
	{
		var input = new int[] { 1, 1, 2 };

		var result = RemoveDuplicates(input);
		Console.WriteLine(result);
	}

	public static int RemoveDuplicates(int[] nums)
	{
		var l = 1;

		for (int r = 1; r < nums.Length; r++)
		{
			if (nums[r] != nums[r - 1])
			{
				//new valuenums
				nums[l] = nums[r];
				l++;
			}
		}

		return l;
	}
}