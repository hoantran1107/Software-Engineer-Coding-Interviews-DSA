
namespace DSATest.SeachTest;
public class BinarySearchTest
{
    [Test]
    public void ExistingValue_ReturnsCorrectIndex()
    {
        var arr = new[] { 1, 2, 4, 6, 11, 32, 99 };
        var result = new DSA.Search.BinarySeach().Search(arr, 32);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void MissingValue_ReturnsMinusOne()
    {
        var arr = new[] { 1, 2, 4, 6, 11, 32, 99 };
        var result = new DSA.Search.BinarySeach().Search(arr, 7);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void FirstAndLast_ReturnCorrectIndices()
    {
        var arr = new[] { 1, 2, 4, 6, 11, 32, 99 };
        var firstIndex = new DSA.Search.BinarySeach().Search(arr, 1);
        var lastIndex = new DSA.Search.BinarySeach().Search(arr, 99);
        Assert.That(firstIndex, Is.EqualTo(0));
        Assert.That(lastIndex, Is.EqualTo(6));
    }

    [Test]
    public void EmptyArray_ReturnsMinusOne()
    {
        var arr = new int[0];
        var result = new DSA.Search.BinarySeach().Search(arr, 10);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void SingleElement_FoundAndNotFound()
    {
        var arr = new[] { 5 };
        var found = new DSA.Search.BinarySeach().Search(arr, 5);
        var notFound = new DSA.Search.BinarySeach().Search(arr, 3);
        Assert.That(found, Is.EqualTo(0));
        Assert.That(notFound, Is.EqualTo(-1));
    }

    [Test]
    public void SearchRecursive_ReturnsCorrectIndex()
    {
        var  arr = new[] { 1, 2, 4, 6, 11, 32, 99 };
        var result = new DSA.Search.BinarySeach().SeachRecursive(arr, 0, arr.Length -1,32);
        Assert.That(result, Is.EqualTo(5));
    }
    
    
    [Test]
    public void SearchRecursive_ReturnsCorrectIndex1()
    {
        var  arr = new[] { 1, 2, 4, 6, 11, 32, 99 };
        var result = new DSA.Search.BinarySeach().SeachRecursive(arr, 0, arr.Length -1,1);
        Assert.That(result, Is.EqualTo(0));
    }
    
    
    [Test]
    public void SearchRecursive_ReturnsCorrectIndex2()
    {
        var  arr = new[] { 1, 2, 4, 6, 11, 32, 99 };
        var result = new DSA.Search.BinarySeach().SeachRecursive(arr, 0, arr.Length -1,99);
        Assert.That(result, Is.EqualTo(6));
    }
    
    
    [Test]
    public void SearchRecursive_ReturnsCorrectIndex3()
    {
        var  arr = new[] { 1, 2, 4, 6, 11, 32, 99 };
        var result = new DSA.Search.BinarySeach().SeachRecursive(arr, 0, arr.Length -1,33);
        Assert.That(result, Is.EqualTo(-1));
    }
}