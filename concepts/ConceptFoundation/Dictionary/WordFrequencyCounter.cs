public class DictionaryPractice
{
    // public void PrintWordFrequency()
    // {
    //     Dictionary<string, int> fc = new Dictionary<string, int>();
    //     string[] fruits = ["apple", "banana", "apple", "cherry", "banana", "apple"];
    //     for (int i = 0; i < fruits.Length; i++)
    //     {
    //         if (fc.TryGetValue(fruits[i],out int count))
    //         {
    //             Console.WriteLine($"{fruits[i]}:{count}");
    //             fc[fruits[i]] = count + 1;
    //         }
    //         else
    //         {
    //             fc[fruits[i]] = 1;
    //         }
    //     }
    //     foreach (var keyValue in fc)
    //     {
    //         Console.WriteLine($"{keyValue.Key}:{keyValue.Value}");
    //     }
    // }

    public void PrintWordFrequency()
    {
        List<FruitsCounter> fruitsCounters = new List<FruitsCounter>();
        string[] fruits = ["apple", "banana", "apple", "cherry", "banana", "apple"];
        for (int i = 0; i < fruits.Length; i++)
        {
            int currentIndex = fruitsCounters.FindIndex(a => a.Fruit == fruits[i]);
            if (currentIndex != -1) // apple 
            {
                fruitsCounters[currentIndex].Count++;
            }
            else
            {
                fruitsCounters.Add(new FruitsCounter { Count = 1, Fruit = fruits[i] });
            }
        }
        foreach (var fruit in fruitsCounters)
        {
            Console.WriteLine($"{fruit.Fruit}:{fruit.Count}");
        }
    }
}
// fruitsCounter[0]= apple,1
// fruits[1]=banana,1
//fruits[2]=
public record FruitsCounter
{
    public int Count { get; set; }
    public string Fruit { get; set; }
}