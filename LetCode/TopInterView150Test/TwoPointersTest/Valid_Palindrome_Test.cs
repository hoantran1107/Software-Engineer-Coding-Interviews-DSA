namespace TopInterView150Test;

public class Valid_Palindrome_Test
{
    [Fact]
    public void TestCase1()
    {
        //Arrange
        var s = "A man, a plan a, canal: Panama";
        //Act
        var validPalindrome = new TopInterView150.TwoPointers.Valid_Palindrome();
        var result = validPalindrome.IsPalindrome(s);
        //Assert
        Assert.True(result);
    }

    [Fact]
    public void TestCase2()
    {
        //Arrange
        var s = "race a car";
        //Act
        var validPalindrome = new TopInterView150.TwoPointers.Valid_Palindrome();
        var result = validPalindrome.IsPalindrome(s);
        //Assert
        Assert.False(result);
    }
}