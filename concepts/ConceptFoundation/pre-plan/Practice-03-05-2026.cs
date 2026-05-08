public class Practice
{
    public void PrintFabonacci()
    {
        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        if (!isNumber || result <= 0)
        {
            Console.WriteLine("Please neter valid input");
            return;
        }
        int a = 0, b = 1, c = 0;
        Console.WriteLine(a);
        Console.WriteLine(b);

        while (c < result)
        {
            Console.WriteLine(c);
            c = a + b;
            a = b; b = c;

        }

    }

    public void PrintFactorial()
    {
        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        if (!isNumber || result <= 0)
        {
            Console.WriteLine("Please neter valid input");
            return;
        }

        int factorial = 1;
        for (int i = 1; i <= result; i++)
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
        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        if (!isNumber || result <= 0)
        {
            Console.WriteLine("Please neter valid input");
            return;
        }

        int numberToCheck = result;
        int reverseOfNumber = 0;
        while (result != 0)
        {
            int lastDigit = result % 10;
            result = result / 10;
            reverseOfNumber = lastDigit + 10 * reverseOfNumber;
        }
        Console.WriteLine(reverseOfNumber == numberToCheck ? "Plaindrome" : "Not Plaindrome");
    }

    public void CheckPrimeNumber()
    {

        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        if (!isNumber || result <= 0)
        {
            Console.WriteLine("Please neter valid input");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= result - 1; i++)
        {
            if (result % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime);

    }

    public void PrintPrimeNumbers()
    {


        //brute force with O(n^2)
        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        if (!isNumber || result <= 0)
        {
            Console.WriteLine("Please neter valid input");
            return;
        }

        for (int i = 2; i <= result; i++) //2,3,4,5,6,7,8,9,10
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }

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
        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        if (!isNumber || result <= 0)
        {
            Console.WriteLine("Please neter valid input");
            return;
        }

        int reverseOfNumber = 0;
        while (result != 0)
        {
            int lastDigit = result % 10;
            result = result / 10;
            reverseOfNumber = lastDigit + 10 * reverseOfNumber;
        }

        Console.WriteLine(reverseOfNumber);
    }

    public void PrintSumOfDigits()
    {
        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        if (!isNumber || result <= 0)
        {
            Console.WriteLine("Please neter valid input");
            return;
        }

        int sumOfDigits = 0;
        while (result != 0)
        {
            int lastDigit = result % 10;
            result = result / 10;
            sumOfDigits = lastDigit + sumOfDigits;
        }

        Console.WriteLine(sumOfDigits);
    }

    public void FindLargetNumber()
    {
        int[] numbers = [3, 5, 2, 8, 10, 12, 1, 2, 20];
        int largestNum = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > largestNum)
            {
                largestNum = numbers[i];
            }
        }
        Console.WriteLine(largestNum);
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
        int count = 0;
        for (int i = 0; i < userInput.ToCharArray().Length; i++)
        {
            char[] chars = userInput.ToCharArray();
            if (vowels.Contains(chars[i]))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}