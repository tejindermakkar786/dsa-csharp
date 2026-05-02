/*

take a vowels string
take a user input and check for valid input
loop through each character and compare against vowels
increment the count if vowel exists
print count

the time compalixity in this code is O(n)
space complaxity is o(4)
 */

public class Vowels
{
    string vowels = "aeiouAEIOU";
    public void PrintVowelCount()
    {
        string? userInput = Console.ReadLine();  //Hello World
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Please enter valid string");
            return;
        }

        int count = 0;
        for (int i = 0; i < userInput?.Length; i++)
        {
            // if (vowels.Contains(userInput[i]))
            // {
            //     count++;
            // }
            // if (string.Equals(userInput[i].ToString(), "a", StringComparison.OrdinalIgnoreCase) ||
            // string.Equals(userInput[i].ToString(), "e", StringComparison.OrdinalIgnoreCase) ||
            // string.Equals(userInput[i].ToString(), "i", StringComparison.OrdinalIgnoreCase) ||
            // string.Equals(userInput[i].ToString(), "o", StringComparison.OrdinalIgnoreCase) ||
            // string.Equals(userInput[i].ToString(), "u", StringComparison.OrdinalIgnoreCase))
            // {
            //     count++;
            // }

            for (int j = 0; j < 10; j++)
            {
                if (vowels[j] == userInput[i])
                {
                    count++;
                    break;
                }
            }
        }

        Console.WriteLine($"Vowel count in word {userInput} is:  {count}");
    }
}