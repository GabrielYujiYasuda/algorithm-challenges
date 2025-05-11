using System.Xml.Linq;

internal class Program
{
	private static void Main(string[] args)
	{
	}

	public static void ReversetBT()
	{
		if (node is null)
			return -0;

		ReversetBT(node.left);
		ReversetBT(node.right);

		node.left = node.right;
		node.right = node.left;
	}
}