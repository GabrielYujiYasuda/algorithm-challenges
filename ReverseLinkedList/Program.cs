public ListNode ReverseList(ListNode head)
{

	ListNode prev = null;
	ListNode current = head;
	ListNode next;

	while (current is not null)
	{
		next = current.next;

		current.next = prev;
		prev = current;

		current = next;
	}

	return head = prev;
}