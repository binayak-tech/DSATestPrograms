namespace TestPrograms
{
    public class ArrayTechniques
    {
        /// <summary>
        /// Binary search algorthm
        /// Uses O(logN) time complexity to search an item in an array.
        /// </summary>
        public void BinarySearch()
        {
            int[] nums = { 11, 22, 33, 44, 55, 66, 77, 88 };
            int searchItem = 33;
            int low = 0;
            int high = nums.Length - 1;


            while (low <= high)
            {
                // we can do (low+high)/2 but the current approach produces same result and avoids risk of low+high reaching int size
                int mid = low + (high - low) / 2;

                if (nums[mid] == searchItem)
                {
                    Console.WriteLine($"Binary Search: Found Item {searchItem} at position {mid + 1}.");
                    break;
                }
                else if (nums[mid] < searchItem)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }

        /// <summary>
        /// Example: Finding a pair with a given sum in a sorted array
        /// </summary>
        public void TwoPointer()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int targetSum = 6;
            int left = 0; int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == targetSum)
                {
                    Console.WriteLine($"Two Pointer: Pair Found: ({nums[left]}, {nums[right]})");
                    break;
                }
                if (sum < targetSum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        /// <summary>
        /// Example: Finding the maximum sum of a subarray of size k
        /// </summary>
        public void SlidingWindow()
        {
            int[] nums = { 2, 1, 5, 1, 3, 2 };
            int k = 3;
            int maxSum = 0, windowSum = 0;

            // Calculate the sum of the first window
            for (int i = 0; i < k; i++)
                windowSum += nums[i];

            maxSum = windowSum;

            // Slide the window across the array
            for (int i = k; i < nums.Length; i++)
            {
                windowSum += nums[i] - nums[i - k]; // Slide the window by one position
                maxSum = Math.Max(maxSum, windowSum);
            }

            Console.WriteLine($"Sliding Window: Maximum sum of a subarray of size {k} is: {maxSum}");
        }
    }


}
