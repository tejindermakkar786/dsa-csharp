public class TwoSumUsingHashSet
{
    public int[] PrintTwoSum()
    {
        // int[] nums = [2, 7, 11, 15];
        // int target = 22;
        // Dictionary<int, int> set = new Dictionary<int, int>();
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     int x = target - nums[i];  // 22-2=20
        //     if (set.ContainsKey(x))   //!20
        //     {
        //         return new[] { set[x], i };
        //     }
        //     set[nums[i]] = i;
        // }

        // return [];

        int[] nums = [2, 7, 11, 15];
        int target = 22;
        List<int> ints = new List<int>();
        Dictionary<int, int> set = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }

        }

        return [];
    }
}