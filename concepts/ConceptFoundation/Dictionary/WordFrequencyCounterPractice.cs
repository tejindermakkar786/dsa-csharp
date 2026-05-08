public class WFCPractice
{
    public void PrintWordFrequency()
    {
        string[] words={"apple","banana","apple","cherry","banana","apple"};
        Dictionary<string, int> keyValuePairs=new Dictionary<string, int>();
        foreach (var word in words)
        {
            if(keyValuePairs.TryGetValue(word,out int count))
            {
                keyValuePairs[word]=count+1;
            }
            else
            {
                keyValuePairs[word]=1;
            }
        }
        foreach (var keyValuePair in keyValuePairs)
        {
            Console.WriteLine($"{keyValuePair.Key}:{keyValuePair.Value}");
        }

    }
}