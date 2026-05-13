public class LongChain
{
    public void PrintLongNums()
    {
        int[] chain = [100, 4, 101, 1, 99, 3];

        HashSet<int> set = [.. chain];
        List<int> chainArray = [];
        foreach (var number in chain)  //100
        {
            if (set.Contains(number - 1)) continue;

            List<int> currentChain = [];
            int next = number;
            while (set.Contains(next))
            {
                currentChain.Add(next);
                next++;
            }
            if (currentChain.Count > chainArray.Count)
            {
                chainArray = currentChain;
            }
        }
        foreach (var num in chainArray)
        {
            Console.WriteLine($"Long chain is: {num}");
        }

    }

}