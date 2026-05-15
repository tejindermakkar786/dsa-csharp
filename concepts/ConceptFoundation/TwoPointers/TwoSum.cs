public class TwoSum
{
    public void PrintTwoSum()
    {
        int[] nums = [2, 7, 10, 11, 15];
        int target = 9;
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            int sum = nums[left] + nums[right];
            if (sum < target)
            {
                left++;
            }
            else if (sum > target)
            {
                right--;
            }
            else
            {
                Console.WriteLine($"two sum indexes are: {left} and {right}");
                break;
            }
        }
    }
}