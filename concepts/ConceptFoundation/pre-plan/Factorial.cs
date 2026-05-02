/*

1. start with user entered number
2. take variable name factorial and assign it with 1
3. iterate using for loop and start i from 1
4. repeat until i crosses entered number
5. in the loop multiply factorial by i and assign it to factorial
6. print factorial

 */


// ═══════════════════════════════════════════════════
// Problem   : Find factorial of a number N
// Approach  : Multiply result by every number from 1 to N
// Pattern   : Accumulator — running product
// ───────────────────────────────────────────────────
// Time      : O(n) — one iteration per number up to N
// Space     : O(1) — one result variable only
// ───────────────────────────────────────────────────
// Key Insight: result starts at 1, multiply by i each step
//              result *= i is the same as result = result * i
// Edge Cases : 0! = 1 by definition, negative input invalid
// ═══════════════════════════════════════════════════
public class Factorial
{
    public void print()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}