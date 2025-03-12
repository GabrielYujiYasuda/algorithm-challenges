using TwoSum;

internal class Program
{
	private static void Main(string[] args)
	{
		int[] nums = [2, 5, 5, 11];
		int target = 10;

		TwoSumChallenge twoSumChallenge = new TwoSumChallenge();

		int[] result = twoSumChallenge.Execute(nums, target);

		Array.ForEach(result, Console.WriteLine);
	}
}