namespace KataNextSmallNumber
{
    public class NextSmallNumberFinder
    {
        public static long NextSmallNumber(long targetNumber)
        {
            if (targetNumber == 0)
            {
                return -1;
            }

            var charArray = targetNumber.ToString().ToCharArray();
            for (int i = charArray.Length - 1; i > 0; i--)
            {
                var temp = charArray[i];
                charArray[i] = charArray[i - 1];
                charArray[i - 1] = temp;
                break;
            }

            return long.Parse(new string(charArray));
        }
    }
}