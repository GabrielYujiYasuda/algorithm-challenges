namespace BinarySearch
{
	public class BinarySearchAlgo
	{
		public int Execute(int[] arr, int target)
		{
			var min = 0;
			var max = arr.Length - 1;

			while (min <= max)
			{
				var middle = min + (max - min) / 2;

				if (arr[middle] == target)
					return middle;

				else if (arr[middle] > target)
					max = middle - 1;

				else
					min = middle + 1;
			}

			return -1;
		}
	}
}
