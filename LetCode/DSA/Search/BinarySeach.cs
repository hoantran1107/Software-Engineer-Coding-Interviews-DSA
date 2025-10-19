namespace DSA.Search;

public class BinarySeach
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (target < nums[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }

    public int SeachRecursive(int[] nums, int left, int right, int target)
    {
        if (left <= right)
        {
            var mid = (left + right) /2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (target < nums[mid])
            {
               return SeachRecursive(nums, left, mid - 1, target);
            }
            else
            {
               return SeachRecursive(nums, mid + 1, right, target);
            }
        }
        else
        {
            return -1;
        }
    }
}