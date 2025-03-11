using PalindromeNumber;

internal class Program
{
	private static void Main(string[] args)
	{
		//Given an integer x, return true if x is a palindrome, and false otherwise.
		PalindromeNumberChallenge palindromeNumberChallenge = new PalindromeNumberChallenge();

		var result = palindromeNumberChallenge.Execute(121);

		Console.WriteLine();
	}
}