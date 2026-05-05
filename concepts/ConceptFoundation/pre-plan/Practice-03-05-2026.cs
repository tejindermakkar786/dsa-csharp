public class Practice
{
    public void PrintFabonacci()
    {
        int number = GetUserInput();
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number.");
            return;
        }
        int a = 0;
        int b = 1;
        int c = 0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 0; i <= number; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine(c);
        }
    }

    public void PrintFactorial()
    {
        int number = GetUserInput();
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number.");
            return;
        }

        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine(factorial);
    }

    public void PrintFizzBuzz()
    {

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
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

    public void PrintPalindrome()
    {
        int number = GetUserInput();
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number.");
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

        int number = GetUserInput();
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number.");
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
        Console.WriteLine(isPrime ? "Prime number" : "Not Prime");

    }

    private static int GetUserInput()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number.");
            return number;
        }

        return number;
    }

    public void PrintReverseOfNumber()
    {
        int number = GetUserInput();
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number.");
            return;
        }

        int reverseOfNumber = 0;
        while (number != 0)
        {
            int lastDigit = number % 10;
            if(lastDigit%2==0)
            {
                
            }
            number = number / 10;
            reverseOfNumber = lastDigit + 10 * reverseOfNumber;
        }

        Console.WriteLine(reverseOfNumber);
    }

    public void PrintSumOfDigits()
    {
        int number = GetUserInput();
        if (number <= 0)
        {
            Console.WriteLine("Please enter valid number.");
            return;
        }

        int reverseOfNumber = 0;
        while (number != 0)
        {
            int lastDigit = number % 10;
            number = number / 10;
            reverseOfNumber = lastDigit + reverseOfNumber;
        }

        Console.WriteLine(reverseOfNumber);
    }

    public void FindLargetNumber()
    {
        int[] numbers = [3, 5, 6, 1, 2, 10, 34, 21];
        int largestNumber = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }
        Console.WriteLine(largestNumber);
    }

    public void PrintVowelCount()
    {
        string vowels = "aeiouAEIOU";
        string userInput = Console.ReadLine();
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Please enter valid input");
            return;
        }
        int count=0;
        for (int i = 0; i < userInput.ToCharArray().Length; i++)
        {
            char[] chars=userInput.ToCharArray();
            if(vowels.Contains(chars[i]))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}