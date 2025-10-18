namespace LetCode._9_palindrome_number;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        var originalX = x;
        x = x < 0 ? -x : x;
        var rev = 0;
        while (x != 0)
        {
            var digit = x % 10;
            rev = rev * 10 + digit;
            x = x / 10;
        }

        var revToString = x < 0 ? rev + "-" : rev.ToString();
        return revToString == originalX.ToString();
    }
}