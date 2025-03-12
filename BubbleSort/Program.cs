using BubbleSort;

var bbs = new BubbleSortAlgorithm();
int[] arr = { 29, 12, 30, 1, 4, 65, 7, 99, 54 }; 

bbs.Sort(arr);

foreach(int x in arr)
{
	Console.WriteLine(x);
}

