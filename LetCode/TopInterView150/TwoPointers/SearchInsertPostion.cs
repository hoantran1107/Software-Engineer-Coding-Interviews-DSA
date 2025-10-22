namespace TopInterView150.TwoPointers;

public class SearchInsertPostion
{
    //https://leetcode.com/problems/search-insert-position/submissions/1805714231/?envType=problem-list-v2&envId=binary-search
    public int SearchInsert(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length -1;
        if(numbers[left] > target) return 0;
        if(numbers[right] < target) return right +1;

        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (numbers[left] < target && target < numbers[right] && left + 1 == right) return left +1;
            if (numbers[mid] == target) return mid;
            if(numbers[mid] < target){
                
                left = mid;
            }
            else{
                right = mid;
            }
        } 
        return -1;
    }
}