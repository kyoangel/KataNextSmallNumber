namespace KataNextSmallNumber
{
    public class NextSmallNumberFinder
    {
        public static long NextSmallNumber(long targetNumber)
        {
            var charArray = targetNumber.ToString().ToCharArray();
            for (int i = charArray.Length - 1; i > 0; i--)
            {
                if (charArray[i] < charArray[i - 1])
                {
                    var temp = charArray[i];
                    charArray[i] = charArray[i - 1];
                    charArray[i - 1] = temp;
                    return long.Parse(new string(charArray));
                }
            }

            return -1;
        }
    }
}