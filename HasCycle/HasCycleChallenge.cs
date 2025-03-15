namespace HasCycle
{
    public class HasCycleChallenge
    {
		public bool HasCycle(ListNode head)
		{
			public bool Execute(ListNode head)
			{
				ListNode slow = head;
				ListNode fast = head;

				while (fast is not null && fast.next is not null)
				{
					slow = slow.next;
					fast = fast.next.next;

					if (slow == fast)
						return true;
				}

				return false;
			}
		}
	}
}
