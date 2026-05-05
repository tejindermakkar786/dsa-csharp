public class Dictionary
{
    public void PrintBlock2()
    {
        var scores = new Dictionary<string, int>();
        scores["Raj"] = 95;
        scores["Priya"] = 100;
        scores["Amit"] = 87;
        Console.WriteLine(scores["Priya"]);
        if (scores.ContainsKey("Priya"))
        {
            Console.WriteLine(scores["Priya"]);
        }
        if (scores.TryGetValue("Priya", out int score))
        {
            Console.WriteLine(score);
        }

        Console.WriteLine(scores.GetValueOrDefault("Priya"));
        Console.WriteLine(scores.GetValueOrDefault("tejinder"));

        foreach (var keyValuePair in scores)
        {
            Console.WriteLine($"{keyValuePair.Key}:{keyValuePair.Value}");
        }

        Console.WriteLine(scores.Count);
        scores.Remove("Raj");
        Console.WriteLine(scores.Count);
    }
}