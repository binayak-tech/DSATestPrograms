namespace TestPrograms
{
    public class ArrayProblems
    {
        /// <summary>
        /// Given a sorted array of integers, find a pair of numbers that add up to a specific target sum. 
        /// If there are multiple pairs, return any one of them. 
        /// If no such pair exists, return a message indicating that.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="targetSum"></param>
        public (int, int)? FindPairWithGivenSum(int[] nums, int targetSum)
        {
            int left = 0, right = nums.Length - 1;
            if (nums.Length < 2) 
            {
                return null;
            }
            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == targetSum)
                {
                    return (nums[left], nums[right]);
                }
                else if (sum < targetSum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return null;
        }
    }
}
