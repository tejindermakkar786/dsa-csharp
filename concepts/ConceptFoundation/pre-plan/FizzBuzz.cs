// ═══════════════════════════════════════════════════
// Problem   : Print 1 to 100 with Fizz Buzz FizzBuzz rules
// Approach  : Check divisibility conditions in correct order
// Pattern   : Conditional — specific condition before general
// ───────────────────────────────────────────────────
// Time      : O(n) — one iteration per number 1 to 100
// Space     : O(1) — no extra memory used
// ───────────────────────────────────────────────────
// Key Insight: check BOTH (div by 3 AND 5) first
//              then check each alone
//              more specific condition must come before general
//              otherwise FizzBuzz case gets swallowed by Fizz
// Edge Cases : none — fixed range 1 to 100
// ═══════════════════════════════════════════════════

public class FizzBuzz
{
    public void Print()
    {
        int number = Convert.ToInt32(Console.ReadLine());  //12345
        if (number <= 0 || number > 100)
        {
            Console.WriteLine("Please enter valid number");
            return ;
        }

        string status = string.Empty;
        for (int i = 1; i <= number; i++)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                status = "FizzBuzz";
                break;
            }
            else if (number % 3 == 0)
            {
                status = "Fizz";
                break;
            }
            else if (number % 5 == 0)
            {
                status = "Buzz";
                break;
            }
            else
            {
                status = "Unknown";
                break;
            }


        }

        Console.WriteLine($"status of number {number} is {status}");
    }
}