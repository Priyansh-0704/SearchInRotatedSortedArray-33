public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0, end = nums.Length - 1;
        while(start <= end)
        {
            int mid = start + (end - start) / 2;

            if(nums[mid] == target)
            {
                return mid;
            }
            if(nums[start] <= nums[mid])
            {
                // left half is sorted
                if(nums[start] <= target && target <= nums[mid])
                {
                    // target presenet in the left half
                    end = mid - 1;
                } else
                {
                    // target present in the right half
                    start = mid + 1;
                }
            } else
            {
                // right half is sorted
                if(nums[mid] <= target && target <= nums[end])
                {
                    // target present in the right half
                    start = mid + 1;
                } else{
                    // target present in the left part
                    end = mid - 1;
                }
            }
        }
        return -1;
    }
}

// The idea is that one half of the array is always sorted, find that half and find out whether the target is in that part or the other (unsorted) part.
// 6 8 9 1 2 3 4 5
