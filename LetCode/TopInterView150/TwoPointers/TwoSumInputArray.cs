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

    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;
        while (left <= numbers.Length - 1)
        {
            var temp = target - numbers[left];
            while(temp < right){
                var mid = (temp + right) / 2;
                if(numbers[mid] == temp) return new[] {left, mid};

                if(numbers[mid] > target){
                    left = mid + 1;
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