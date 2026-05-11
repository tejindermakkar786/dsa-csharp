public class HashsetPractice
{
    public void CheckDupilcate()
    {
        HashSet<int> seen = new HashSet<int>();
        seen.Add(3);
        seen.Add(7);
        seen.Add(2);
        seen.Add(2);

        Console.WriteLine(seen.Contains(3)); //O(1)
        Console.WriteLine(seen.Contains(9)); //O(1)
        foreach (var item in seen)
        {
            Console.WriteLine(item);
        }
    }
}