using BinarySearch;

var bs = new BinarySearchAlgo();

var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
var target = 12;

var result = bs.Execute(input, target);

Console.WriteLine(result);