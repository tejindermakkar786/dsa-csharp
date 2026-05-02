public class ArrayBasics
{
    int[] numbers = { 3, 2, 7, 9, 8 };
    public void PrintArray()
    {
        Console.WriteLine(numbers[0]); // o(1)
        Console.WriteLine("O(3)");

        Console.WriteLine(numbers[3]); // o(3)
        Console.WriteLine("Total length");
        Console.WriteLine(numbers.Length);  // total length
        Console.WriteLine("Iterating through the array");
        for (int i = 0; i < numbers.Length; i++) //O(n)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    // find the largest number in the array

    public void FindLargetNumber()
    {
        int largetsNumber = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > largetsNumber)
            {
                largetsNumber = numbers[i];
            }
        }
        Console.WriteLine("Largest number in array is: " + largetsNumber);
        Console.WriteLine("My loop runs 5 times hence the complaxity is O(n): Big O is O(n)");
    }
}