using LetCode._9_palindrome_number;
using Xunit;

namespace TestProject;

public class Palindrome_Number
{
    [Fact]
    public void Test1()
    {
        var x = 121;
        var solution = new Solution();
        var result = solution.IsPalindrome(x);
        Assert.True(result);
    }

    [Fact]
    public void Test2()
    {
        var x = -121;
        var solution = new Solution();
        var result = solution.IsPalindrome(x);
        Assert.False(result);
    }

    [Fact]
    public void Test3()
    {
        var x = 10;
        var solution = new Solution();
        var result = solution.IsPalindrome(x);
        Assert.False(result);
    }
}