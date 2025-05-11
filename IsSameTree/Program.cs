internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
	}

	public static Boolean IsSameTree() 
	{
		if (p is null && q is null)
			return true;

		if ((p is null || q is null) || (p.val != q.val))
			return false;

		return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
	}
}
