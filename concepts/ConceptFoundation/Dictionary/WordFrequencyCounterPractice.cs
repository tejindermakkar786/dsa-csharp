public class WFCPractice
{
    public void PrintWordFrequency()
    {
        string[] words = ["apple", "apple", "apple", "apple", "apple", "apple"];
        Dictionary<string, int> wordsDic = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (wordsDic.TryGetValue(words[i], out int count))
            {
                wordsDic[words[i]] = count + 1;
            }
            else
            {
                wordsDic[words[i]] = 1;
            }
        }

        foreach (var fc in wordsDic)
        {
            Console.WriteLine($"{fc.Key}:{fc.Value}");
        }

    }
}