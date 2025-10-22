using TopInterView150.TwoPointers;

namespace TopInterView150Test.TwoPointersTest;

public class SearchInsertPositionTest
{
    
    [Fact]
    public void SearchInsertPosition0()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 0);
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void SearchInsertPosition1()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 5);
        Assert.Equal(2, result);
    }

    [Fact]
    public void SearchInsertPosition2()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 2);
        Assert.Equal(1, result);
    }

    [Fact]
    public void SearchInsertPosition3()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 7);
        Assert.Equal(4, result);
    }

    [Fact]
    public void SearchInsertPosition4()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 4);
        Assert.Equal(2, result);
    }
    
    
    [Fact]
    public void SearchInsertPosition5()
    {
        var arr = new[] { 1, 3, 5, 6, 7 };
        var result = new SearchInsertPostion().SearchInsert(arr, 4);
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void SearchInsertPosition6()
    {
        var arr = new[] { 1, 3, 5, 6, 8 };
        var result = new SearchInsertPostion().SearchInsert(arr, 7);
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void SearchInsertPosition7()
    {
        var arr = new[] { 1, 3 };
        var result = new SearchInsertPostion().SearchInsert(arr, 2);
        Assert.Equal(1, result);
    }
}