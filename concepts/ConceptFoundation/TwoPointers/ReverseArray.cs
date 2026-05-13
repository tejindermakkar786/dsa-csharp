public class TwoPointer
{
    public void PrintReverseOfArray()
    {
        int[] nums = [1, 2, 3, 4, 5, 6];
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
            left++;
            right--;
        }

        foreach (var number in nums)
        {
            Console.WriteLine(number);
        }
    }
}