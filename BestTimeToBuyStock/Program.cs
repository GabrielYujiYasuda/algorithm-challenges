internal class Program
{
	//You are given an array prices where prices[i] is the price of a given stock on the ith day.
	//You want to maximize your profit by choosing a single day to buy one stock and choosing 
	//a different day in the future to sell that stock.
	//Return the maximum profit you can achieve from this transaction.
	//If you cannot achieve any profit, return 0.

	private static void Main(string[] args)
	{
		var input = new int[] { 3, 2, 6, 5, 0, 3 };
		var result = MaxProfit(input);

		Console.WriteLine(result);
	}

	public static int MaxProfit(int[] prices)
	{
		var pricesLenght = prices.Length;

		var leftPointer = 0;
		var rightPointer = 1;
		var maxProfit = 0;

		while (rightPointer < pricesLenght)
		{
			if (prices[leftPointer] < prices[rightPointer])
			{
				var profit = prices[rightPointer] - prices[leftPointer];
				maxProfit = Math.Max(profit, maxProfit);
			}
			else
			{
				leftPointer = rightPointer;
			}

			rightPointer++;
		}

		return maxProfit;
	}
}