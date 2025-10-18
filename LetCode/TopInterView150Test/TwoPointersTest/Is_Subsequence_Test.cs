namespace TopInterView150Test;

public class Is_Subsequence_Test
{
    [Fact]
    public void TestCase1()
    {
        //Arrange
        var s = "abc";
        //Act
        var result = new TopInterView150.TwoPointers.Is_Subsequence().IsSubsequence(s, "ahbgdc");
        //Assert
        Assert.True(result);
    }

    [Fact]
    public void TestCase2()
    {
        //Arrange
        var s = "axc";
        //Act
        var result = new TopInterView150.TwoPointers.Is_Subsequence().IsSubsequence(s, "ahbgdc");
        //Assert
        Assert.False(result);
    }
}