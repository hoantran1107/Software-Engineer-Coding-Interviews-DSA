namespace DSA.Search;

public class SearchInsertPostion
{
    public int SearchInsert(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length -1;
        if(nums[left] > target) return 0;
        if(nums[right] < target) return right +1;

        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[left] < target && target < nums[right] && left + 1 == right) return left +1;
            if (nums[mid] == target) return mid;
            if(nums[mid] < target){
                
                left = mid;
            }
            else{
                right = mid;
            }
        } 
        return -1;
    }
}