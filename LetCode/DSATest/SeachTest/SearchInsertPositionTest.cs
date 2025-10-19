using DSA.Search;

namespace DSATest.SeachTest;

public class SearchInsertPositionTest
{
    
    [Test]
    public void SearchInsertPosition0()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 0);
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void SearchInsertPosition1()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 5);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void SearchInsertPosition2()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 2);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void SearchInsertPosition3()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 7);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void SearchInsertPosition4()
    {
        var arr = new[] { 1, 3, 5, 6 };
        var result = new SearchInsertPostion().SearchInsert(arr, 4);
        Assert.That(result, Is.EqualTo(2));
    }
    
    
    [Test]
    public void SearchInsertPosition5()
    {
        var arr = new[] { 1, 3, 5, 6, 7 };
        var result = new SearchInsertPostion().SearchInsert(arr, 4);
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void SearchInsertPosition6()
    {
        var arr = new[] { 1, 3, 5, 6, 8 };
        var result = new SearchInsertPostion().SearchInsert(arr, 7);
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void SearchInsertPosition7()
    {
        var arr = new[] { 1, 3 };
        var result = new SearchInsertPostion().SearchInsert(arr, 2);
        Assert.That(result, Is.EqualTo(1));
    }
}