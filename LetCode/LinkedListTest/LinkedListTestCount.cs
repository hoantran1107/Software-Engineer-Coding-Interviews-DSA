using LinkedList;
using Xunit;

namespace LinkedListTest;

public class LinkedListTestCount
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        var result = solution.LengthOfLinkedList(head);
        Assert.Equal(3, result);
    }

    [Fact]
    public void LinkedListRecursiveLength()
    {
        var solution = new Solution();
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        var result = solution.CountLength(head);
        Assert.Equal(3, result);
    }
}