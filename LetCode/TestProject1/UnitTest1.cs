using LinkedList;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        var result = solution.LengthOfLinkedList(head);
        Assert.Equal(3, result);
    }
}