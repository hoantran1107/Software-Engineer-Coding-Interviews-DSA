using LinkedList;

namespace ListedListTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test1()
    {
        var sulution = new Solution();
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        var result = sulution.LengthOfLinkedList(head);
        Assert.(3, result);
    }
}