public class VowelsPractice
{
    public void Print()
    {
        string vowels = "aeiouAEIOU";
        string userInput = Console.ReadLine();
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Please enter valid input");
            return;
        }

        char[] chars = userInput.ToLower().ToCharArray();
        int vowelsCount = 0;
        foreach (var letter in chars)
        {
            // if (vowels.Contains(letter))
            // {
            //     vowelsCount++;
            // }
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                vowelsCount++;
            }
        }

        Console.WriteLine(vowelsCount);
    }
}