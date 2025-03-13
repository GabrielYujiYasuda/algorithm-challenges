namespace ContainsDuplicate
{
	public class ContainsDuplicateChallenge
	{
		//Given an integer array nums, return true if any value
		//appears at least twice in the array, and return false
		//if every element is distinct.

		public bool Execute(int[] nums)
		{
			var list = new List<int>();

			foreach (int i in nums)
			{
				if (list.Contains(i))
					return true;
				else
					list.Add(i);
			}

			return false;

			//for (int i = 0; i < nums.Length; i++)
			//{
			//	for (int j = 0; j < i + 1; j++)
			//	{
			//		var diffIndex = i != j;

			//		if (nums[i] == nums[j] && diffIndex)
			//			return true;
			//	}
			//}

			//return false;
		}
	}
}