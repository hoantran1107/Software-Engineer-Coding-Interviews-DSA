namespace TopInterView150Test.TwoPointersTest;

public class TwoSumInputArrayTest
{
    [Fact]
    public void TwoSumInputArrayWithReturnCorrect()
    {
        var arr = new[] { 2, 7, 11, 15 };
        var result = new TopInterView150.TwoPointers.TwoSumInputArray().TwoSum(arr, 9);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSumInputArrayWithReturnCorrect2()
    {
        var arr = new[] { 2, 7, 11, 15 };
        var result = new TopInterView150.TwoPointers.TwoSumInputArray().TwoSum(arr, 9);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSumInputArrayWithReturnCorrect3()
    {
        var arr = new[] {-1, 0 };
        var result = new TopInterView150.TwoPointers.TwoSumInputArray().TwoSum(arr, -1);
        Assert.Equal(new[] { 0, 1 }, result);
    }
}