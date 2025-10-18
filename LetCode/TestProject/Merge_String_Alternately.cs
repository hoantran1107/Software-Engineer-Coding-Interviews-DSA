using System.Linq;
using _1768_Merge_Strings_Alternately;
using Xunit;

namespace TestProject;

public class Merge_String_Alternately
{
    [Fact]
    public void Test1()
    {
        string word1 = "abc", word2 = "pqr";
        var solution = new Class1();
        var result = solution.MergeAlternately(word1, word2);
        Assert.Equal("apbqcr", result);
    }

    [Fact]
    public void Test2()
    {
        string word1 = "ab", word2 = "pqrs";
        var solution = new Class1();
        var result = solution.MergeAlternately(word1, word2);
        Assert.Equal("apbqrs", result);
    }

    [Fact]
    public void Test3()
    {
        string word1 = "abcd", word2 = "pq";
        var solution = new Class1();
        var result = solution.MergeAlternately(word1, word2);
        Assert.Equal("apbqcd", result);
    }

    [Fact]
    public void Test6()
    {
        string word1 = "a", word2 = "b";
        var solution = new Class1();
        var result = solution.MergeAlternately(word1, word2);
        Assert.Equal("ab", result);
    }

    [Fact]
    public void Test7()
    {
        string word1 = "a", word2 = "bcd";
        var solution = new Class1();
        var result = solution.MergeAlternately(word1, word2);
        Assert.Equal("abcd", result);
    }

    [Fact]
    public void Test8()
    {
        string word1 = "xyz", word2 = "p";
        var solution = new Class1();
        var result = solution.MergeAlternately(word1, word2);
        Assert.Equal("xpyz", result);
    }

    [Fact]
    public void TestWord1Length100_Word2Length100()
    {
        var word1 = new string('x', 100);
        var word2 = new string('y', 100);
        var solution = new Class1();
        var result = solution.MergeAlternately(word1, word2);
        // Should alternate x and y, starting with x
        var expected = string.Concat(Enumerable.Repeat("xy", 100));
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Testcadf()
    {
        var word1 = new string("cdf");
        var word2 = new string("a");
        var solution = new Class1();
        var result = solution.MergeAlternately(word1, word2);
        Assert.Equal("cadf", result);
    }
}