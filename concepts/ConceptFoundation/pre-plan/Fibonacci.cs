// ═══════════════════════════════════════════════════
// Problem   : Print Fibonacci series up to a limit
// Approach  : Rotate 3 variables — a, b, c each iteration
// Pattern   : Iterative variable rotation
// ───────────────────────────────────────────────────
// Time      : O(n) — one iteration per Fibonacci number
// Space     : O(1) — only 3 variables regardless of input
// ───────────────────────────────────────────────────
// Key Insight: c = a + b, then a = b, then b = c
//              shifts the window forward each step
// Edge Cases : number <= 0 — print error message
// ═══════════════════════════════════════════════════
public class Fibonacci
{

    public void Print()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
            Console.WriteLine("Please enter number greater than 0");
        else
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i <= number; i = a + b)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }

        }


    }

}