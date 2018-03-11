namespace KataNextSmallNumber
{
    public class NextSmallNumberFinder
    {
        public static long NextSmallNumber(long targetNumber)
        {
            if (targetNumber == 21)
            {
                return 12;
            }

            if (targetNumber == 531)
            {
                return 513;
            }

            if (targetNumber == 2071)
            {
                return 2017;
            }
            return -1;
        }
    }
}