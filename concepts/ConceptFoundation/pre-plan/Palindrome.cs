
// ═══════════════════════════════════════════════════
// Problem   : Check whether a number reads same forwards/backwards
// Approach  : Reverse the number, compare with original
// Pattern   : Extract and build + comparison
// ───────────────────────────────────────────────────
// Time      : O(d) — d is number of digits in the number
// Space     : O(1) — original, reversed, lastDigit variables
// ───────────────────────────────────────────────────
// Key Insight: store original BEFORE modifying n
//              reverse using mod and divide
//              if reversed == original then palindrome
//              combines reverse number logic with comparison
// Edge Cases : negative numbers are never palindromes,
//              single digit numbers are always palindromes
// ═══════════════════════════════════════════════════
public class Palindrome
{
    public void Print()
    {
        int number = Convert.ToInt32(Console.ReadLine());  //12345
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number");
        }

        int numberToCheck = number;
        int reversedNumber = 0;
        while (number != 0)
        {
            int lastDigit = number % 10;     //5
            number = number / 10;   //1234
            reversedNumber = lastDigit + 10 * reversedNumber;  //
        }
        Console.WriteLine(reversedNumber==numberToCheck?"Palindrome":"Not Palindrome");
    }
}