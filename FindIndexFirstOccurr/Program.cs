internal class Program
{
	private static void Main(string[] args)
	{
		var haystack = "sadbutsad";
		var needle = "sad";

		var result = StrStr(haystack, needle);
		Console.WriteLine(result);
	}

	// Given two strings needle and haystack,
	// return the index of the first occurrence
	// of needle in haystack, or -1 if needle
	// is not part of haystack.
	public static int StrStr(string haystack, string needle)
	{
		for (int i = 0; i < haystack.Length + 1 - (needle.Length); i++)
		{
			for (int j = 0; j < needle.Length; j++)
			{
				if (haystack[i + j] != needle[j])
					break;

				if (j == needle.Length - 1)
					return i;
			}
		}

		return -1;
	}
}