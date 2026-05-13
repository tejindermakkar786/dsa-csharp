public class ValidPalindrome
{
    public void CheckPalindrome()
    {
        string userInput = Console.ReadLine();
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("invalid input");
            return;
        }

        char[] chars = userInput.ToLower().ToCharArray();
        int left = 0;
        int right = chars.Length - 1;
        bool isPalindrome = true;
        while (left < right)
        {
            if (!chars[left].Equals(chars[right]))
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }
        Console.WriteLine(isPalindrome);
    }
}