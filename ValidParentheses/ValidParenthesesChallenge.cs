namespace ValidParentheses
{
	public class ValidParenthesesChallenge
	{
		//Given a string s containing just the
		//characters '(', ')', '{', '}', '[' and ']',
		//determine if the input string is valid.

		//An input string is valid if:

		//Open brackets must be closed by the same type of brackets.
		//Open brackets must be closed in the correct order.
		//Every close bracket has a corresponding open bracket of the same type

		public bool Execute(string s)
		{
			if (s.Length <= 1)
				return false;

			var hash = new Dictionary<char, char>
			{
				{ ')', '(' },
				{ ']', '[' },
				{ '}', '{' }
			};

			Stack<char> stack = new Stack<char>();

			foreach (char c in s)
			{
				var isClosening = hash.ContainsKey(c);

				if (isClosening)
				{
					var isFirstItem = stack.Count <= 0;
					
					if (!isFirstItem && stack.Peek() == hash[c])
						stack.Pop();
					else
						return false;
				} else
				{
					stack.Push(c);
				}
			}

			return stack.Count == 0;
		}
	}
}
