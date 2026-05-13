public class HappyNumber
{
    public bool IsHappy(int input) {
        HashSet<int> sets = new();
        int squareOfNumber = 0;
        bool isHappy = true;
        while (input != 0)
        {
            int lastDigit = input % 10;
            input /= 10;
            squareOfNumber = lastDigit * lastDigit + squareOfNumber; 
            if (input == 0)
            {

                input = squareOfNumber;
                if (squareOfNumber == 1)
                {
                    isHappy = true;
                    break;
                }
                else if (!sets.Add(squareOfNumber))
                {
                    isHappy = false;
                    break;
                }
                else
                {
                    squareOfNumber = 0;
                    continue;
                }

            }
        }
        return isHappy;
    }
}