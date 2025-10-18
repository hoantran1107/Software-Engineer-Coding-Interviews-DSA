namespace LeetCode._83;

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

/// <summary>
///     LeetCode Problem 83: Remove Duplicates from Sorted List
///     Given the head of a sorted linked list, delete all duplicates such that each element appears only once.
///     Return the linked list sorted as well.
/// </summary>
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var curr = head;

        while (curr != null && curr.next != null)
            if (curr.val == curr.next.val)
            {
                var temp = curr.next.next;
                curr.next = temp;
            }
            else
            {
                curr = curr.next;
            }

        return head;
    }

    public ListNode DeleteDuplicates2(ListNode head)
    {
        var st = new HashSet<int>();
        var temp = head;
        ListNode newHead = null;
        ListNode tail = null;
        while (temp != null)
            if (st.Contains(head.val))
            {
                head = head.next;
            }
            else
            {
                // Create a new node for the unique data
                var newNode = new ListNode(temp.val);
                if (newHead == null)
                {
                    newHead = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.next = newNode;
                    tail = newNode;
                }

                st.Add(temp.val);
            }

        return newHead;
    }
}