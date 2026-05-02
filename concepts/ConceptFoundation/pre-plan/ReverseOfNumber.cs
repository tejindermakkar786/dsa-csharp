
// ═══════════════════════════════════════════════════
// Problem   : Reverse the digits of a number
// Approach  : Extract last digit with mod, build reversed number
// Pattern   : Extract and build — mod 10 + divide 10
// ───────────────────────────────────────────────────
// Time      : O(d) — d is number of digits in the number
// Space     : O(1) — only 3 variables (n, lastDigit, reversed)
// ───────────────────────────────────────────────────
// Key Insight: mod 10 extracts last digit
//              reversed * 10 shifts existing digits left
//              + lastDigit places new digit in ones position
// Edge Cases : negative numbers, single digit, trailing zeros
// ═══════════════════════════════════════════════════

public class ReverseOfNumber
{
    public void Print()
    {
        int numberToReverse = Convert.ToInt32(Console.ReadLine());  //12345
        if (numberToReverse <= 0)
            Console.WriteLine("Please enter valid number");

        int reversedNumber = 0;
        while (numberToReverse != 0)   //12345<=0
        {
            int lastDigit = numberToReverse % 10;   //5
            numberToReverse /= 10;   //1234
            reversedNumber = lastDigit + 10 * reversedNumber;   //5+10*0=5
        }
        Console.WriteLine("Reverse of number is: " + reversedNumber);
    }
}