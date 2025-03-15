namespace MergeTwoSortedList
{
	public class MergeTwoChallenge
	{
		public LinkedListNode<int> Execute(LinkedListNode<int> list1, LinkedListNode list2)
		{
			if (list1 == null) return list2;
			if (list2 == null) return list1;

			if (list1.val <= list2.val)
			{
				list1.val = Execute(list1.val, list2);
				return list1;
			}
			else
			{
				list2.val = Execute(list1, list2.val);
				return list2;
			}
		}
	}
}
