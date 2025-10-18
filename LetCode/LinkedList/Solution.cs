namespace LinkedList;

// Definition for singly-linked list.
public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public int LengthOfLinkedList(ListNode head)
    {
        var length = 0;
        while (head != null)
        {
            length++;
            head = head.next;
        }

        return length;
    }

    public int CountLength(ListNode head)
    {
        if (head == null)
            return 0;
        return 1 + CountLength(head.next);
    }
}