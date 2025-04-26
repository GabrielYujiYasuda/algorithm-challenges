using System.Globalization;

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
		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = 0; j < nums.Length; j++)
			{
				if (nums[i] == nums[j] && j - 1 < nums.Length)
				{
					nums[j] = nums[j + 1];
				}
			}
		}

		return 1;
	}
}