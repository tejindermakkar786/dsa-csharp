using System.Xml.Serialization;

public class Day7Practice
{
    public void PrintFactorial()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Invalid number");
            return;
        }
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine(factorial);
    }

    public void PrintFabonacci()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("invalid number");
        }

        int a = 0, b = 1, c = 0;
        while (true)
        {
            c = a + b;
            if (c > number)
            {
                break;
            }
            a = b;
            b = c;
            Console.WriteLine(c);
        }
    }

    public void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Unknown");
            }
        }
    }

    public void Palindrome()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Invalid number");
            return;
        }
        int reverse = 0;
        int numberToCheck = number;
        while (number != 0)
        {
            int lastDigit = number % 10;
            number = number / 10;
            reverse = lastDigit + 10 * reverse;
        }
        if (reverse == numberToCheck)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }

    public void CheckPrimeNumber()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Invalid number");
            return;
        }
        bool isPrime = true;
        for (int i = 2; i < number - 1; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not a prime");
        }
    }

    public void ReverseOfNumber()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Invalid number");
            return;
        }

        int reverse = 0;
        while (number != 0)
        {
            int lastDigit = number % 10;
            number = number / 10;
            reverse = lastDigit + 10 * reverse;
        }

        Console.WriteLine(reverse);
    }

    public void SumOfInteger()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Invalid number");
            return;
        }

        int sumOfNumber = 0;
        while (number != 0)
        {
            int lastDigit = number % 10;
            number = number / 10;
            sumOfNumber = lastDigit + sumOfNumber;
        }

        Console.WriteLine(sumOfNumber);
    }

    public void FindLargetNumber()
    {
        int[] nums = [10, 20, 50, 25, 56, 12];
        int largestNum = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > largestNum)
            {
                largestNum = nums[i];
            }
        }
        Console.WriteLine(largestNum);
    }

    public void CountVowels()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid input");
        }

        char[] chars = input.ToLower().ToCharArray();
        int count = 0;
        foreach (var letter in chars)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}