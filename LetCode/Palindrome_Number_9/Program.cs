namespace Palindrome_Number_9;

public class Solution {
    public bool IsPalindrome(int x) {
        var rev = 0;
        while (x != 0)
        {
            var digit = x % 10;
            rev = rev * 10 + digit;
            x = x / 10;
        }
        
        return rev.ToString() == x.ToString();
    }
}