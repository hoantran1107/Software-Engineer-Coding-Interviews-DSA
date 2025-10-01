using LeetCode._83;
using Xunit;

namespace LeetCode._83.Tests;

public class SolutionTests
{
    private readonly Solution _solution;

    public SolutionTests()
    {
        _solution = new Solution();
    }

    [Fact]
    public void Test_Example1_RemoveDuplicates_1_1_2()
    {
        // Arrange: [1,1,2]
        var head = new ListNode(1, new ListNode(1, new ListNode(2)));

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert: [1,2]
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.NotNull(result.next);
        Assert.Equal(2, result.next.val);
        Assert.Null(result.next.next);
    }

    [Fact]
    public void Test_Example2_RemoveDuplicates_1_1_2_3_3()
    {
        // Arrange: [1,1,2,3,3]
        var head = new ListNode(1,
            new ListNode(1,
                new ListNode(2,
                    new ListNode(3,
                        new ListNode(3)))));

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert: [1,2,3]
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.NotNull(result.next);
        Assert.Equal(2, result.next.val);
        Assert.NotNull(result.next.next);
        Assert.Equal(3, result.next.next.val);
        Assert.Null(result.next.next.next);
    }

    [Fact]
    public void Test_EmptyList()
    {
        // Arrange: []
        ListNode head = null;

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert: []
        Assert.Null(result);
    }

    [Fact]
    public void Test_SingleNode()
    {
        // Arrange: [1]
        var head = new ListNode(1);

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert: [1]
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.Null(result.next);
    }

    [Fact]
    public void Test_AllDuplicates()
    {
        // Arrange: [1,1,1,1]
        var head = new ListNode(1,
            new ListNode(1,
                new ListNode(1,
                    new ListNode(1))));

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert: [1]
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.Null(result.next);
    }

   
    [Fact]
    public void Test_NoDuplicates()
    {
        // Arrange: [1,2,3,4,5]
        var head = new ListNode(1,
            new ListNode(2,
                new ListNode(3,
                    new ListNode(4,
                        new ListNode(5)))));

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert: [1,2,3,4,5]
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Equal(3, result.next.next.val);
        Assert.Equal(4, result.next.next.next.val);
        Assert.Equal(5, result.next.next.next.next.val);
        Assert.Null(result.next.next.next.next.next);
    }

    [Fact]
    public void Test_TwoNodesNoDuplicates()
    {
        // Arrange: [1,2]
        var head = new ListNode(1, new ListNode(2));

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert: [1,2]
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.NotNull(result.next);
        Assert.Equal(2, result.next.val);
        Assert.Null(result.next.next);
    }

    [Fact]
    public void Test_TwoNodesDuplicates()
    {
        // Arrange: [1,1]
        var head = new ListNode(1, new ListNode(1));

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert: [1]
        Assert.NotNull(result);
        Assert.Equal(1, result.val);
        Assert.Null(result.next);
    }
}
