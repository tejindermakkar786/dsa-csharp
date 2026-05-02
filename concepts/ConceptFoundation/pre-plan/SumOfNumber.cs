
// ═══════════════════════════════════════════════════
// Problem   : Find the sum of all digits in a number
// Approach  : Extract each digit with mod 10, add to sum
// Pattern   : Extract and accumulate — mod 10 + divide 10
// ───────────────────────────────────────────────────
// Time      : O(d) — d is number of digits in the number
// Space     : O(1) — only sum and lastDigit variables
// ───────────────────────────────────────────────────
// Key Insight: same tools as reverse number (mod + divide)
//              but instead of building a number — just add
//              sum = sum + lastDigit (not sum * 10 + lastDigit)
// Edge Cases : negative numbers, single digit number
// ═══════════════════════════════════════════════════

public class SumOfInteger
{
    public void Print()
    {
        int number = Convert.ToInt32(Console.ReadLine());   //12345
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number.");
        }

        int sumOfInteger = 0;
        while (number != 0)
        {
            int mod = number % 10;   //5
            number /= 10;  //1234
            sumOfInteger=mod+sumOfInteger;
        }

        Console.WriteLine(sumOfInteger);
    }
}