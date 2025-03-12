namespace BubbleSort
{
    class BubbleSortAlgorithm
    {
        public void Sort(int[] arr)
        {
            var n = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
				var swapped = false;

				for (int j = 0; j < n - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
						swapped = true;
					}
                }

                if (swapped is false)
                    break;
            }
        }
    }
}
