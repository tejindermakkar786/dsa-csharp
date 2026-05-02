
// ═══════════════════════════════════════════════════
// Problem   : Check whether a number is prime or not
// Approach  : Try dividing by every number from 2 to n-1
// Pattern   : Boolean flag — assume true, disprove with loop
// ───────────────────────────────────────────────────
// Time      : O(n) — checks every number up to n-1
// Space     : O(1) — one boolean flag variable only
// ───────────────────────────────────────────────────
// Key Insight: if any number divides evenly (mod == 0)
//              it is not prime — set flag false and break
//              break early — no need to check further
// Edge Cases : 0 and 1 are not prime, negative numbers invalid
// ═══════════════════════════════════════════════════
public class PrimeNumber
{
    public void Print()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number.");
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }

        Console.WriteLine(isPrime == true ? "Prime Number" : "Not a prime number");
    }
}