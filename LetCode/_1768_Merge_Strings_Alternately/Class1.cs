using System.Text;

namespace _1768_Merge_Strings_Alternately;

public class Class1
{
    public string MergeAlternately(string word1, string word2)
    {
        var stringBuilder = new StringBuilder();
        int i = 0, j = 0;
        while (i < word1.Length || j < word2.Length)
        {
            if(i < word1.Length)
                stringBuilder.Append(word1[i++]);
            if(j < word2.Length)
                stringBuilder.Append(word2[j++]);
        }
        
        return stringBuilder.ToString();
    }
    
    public string MergeAlternately1(string word1, string word2) {
        var tempString = new StringBuilder();
        var endString = string.Empty;
        var i=0;
        if (word1.Length >= word2.Length)
        {
            if (word1.Length == word2.Length)
            {
                for (; i < word1.Length; i++)
                {
                    tempString.Append(word1[i]);
                    tempString.Append(word2[i]);
                }
            }
            else
            {
                for(; i < word2.Length; i++)
                {
                    tempString.Append(word1[i]);
                    tempString.Append(word2[i]);
                }
                endString = word1.Substring(word2.Length);
            }
        }
        else
        {
            for(; i < word1.Length; i++)
            {
                tempString.Append(word1[i]);
                tempString.Append(word2[i]);
            }
            
            endString = word2.Substring(word1.Length);
        }
        
        return  tempString + endString;
    }
}