namespace TopInterView150.TwoPointers;

public class TwoSumInputArray
{
    //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/?envType=study-plan-v2&envId=top-interview-150
    public int[] TwoSum2Loop(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                    return new[] { i, j };
            }
        }
        
        return null;
    }
    
    public int[] TwoSumOptimized(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;
    
        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
        
            if (sum == target)
                return new[] { left + 1, right + 1 };
        
            if (sum < target)
                left++;
            else
                right--;
        }
    
        return [];
    }

    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        while (left <= numbers.Length - 1) //O(n) 
        {
            var temp = target - numbers[left]; 
            var leftTemp = left + 1;
            var right = numbers.Length - 1;
            while(leftTemp <= right){ //O(log n) for binary search
                var mid = (leftTemp + right) / 2;
                if(numbers[mid] == temp) return new[] {left+1, mid+1};
                if(numbers[mid] < temp){
                    leftTemp = mid + 1;
                }
                else{
                    right = mid -1;
                }
            }
            
            left++;
        }
        return [];
    }
}