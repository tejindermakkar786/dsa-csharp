public class VowelsPractice
{
    public void Print()
    {
        string userInput = Console.ReadLine();
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Please enter valid input");
            return;
        }
        int vowelsCount = 0;
        char[] chars = userInput.ToLower().ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char chr = chars[i];
            if (chr == 'a' || chr == 'e' || chr == 'i' || chr == 'o' || chr == 'u')
            {
                vowelsCount++;
            }
        }

        Console.WriteLine(vowelsCount);
    }
}