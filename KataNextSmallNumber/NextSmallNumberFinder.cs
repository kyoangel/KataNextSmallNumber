using System.Linq;

namespace KataNextSmallNumber
{
    public class NextSmallNumberFinder
    {
        private static char[] _charArray;

        /// <summary>
        /// Get the next small number.
        /// Strategy = go from right to left and find the first digit with a number greater to the left
        /// eg 285123 - find the '1' because there's a greater number beside
        /// Find the biggest number to the right, and switch the two
        /// eg 285123 - switch the 5 and the 3 = 283125
        /// Then, sort everything to the right of the index in descending order
        /// eg 283125 -> 283521
        /// </summary>
        /// <param name="targetNumber">The target number.</param>
        /// <returns></returns>
        public static long NextSmallNumber(long targetNumber)
        {
            _charArray = targetNumber.ToString().ToCharArray();

            var theBiggerKeyIndex = GetTheBiggerDigitIndex(_charArray);
            if (theBiggerKeyIndex != -1)
            {
                var biggestRightSideD = GetTheBiggestRightSideDigit(theBiggerKeyIndex);
                Swap(theBiggerKeyIndex, FindBiggestRightSideDigitIndex(theBiggerKeyIndex, biggestRightSideD));
                var originDigit = new string(_charArray).Substring(0, theBiggerKeyIndex + 1);
                var changeOrderDigit = new string(_charArray).Substring(theBiggerKeyIndex + 1).OrderByDescending(x => x).ToArray();
                if ((originDigit + new string(changeOrderDigit))[0].Equals('0'))
                {
                    return -1;
                }

                return long.Parse(originDigit + new string(changeOrderDigit));
            }

            return -1;
        }

        private static int FindBiggestRightSideDigitIndex(int theBiggerKeyIndex, int biggestRightSideDight)
        {
            for (int i = theBiggerKeyIndex; i < _charArray.Length; i++)
            {
                if (_charArray[i] == biggestRightSideDight)
                {
                    return i;
                }
            }

            return -1;
        }

        private static char GetTheBiggestRightSideDigit(int theBiggerKeyIndex)
        {
            return _charArray.Select((x, i) => (i > theBiggerKeyIndex) ? (x < _charArray[theBiggerKeyIndex]) ? x : '0' : '0').Max();
        }

        private static int GetTheBiggerDigitIndex(char[] charArray)
        {
            for (int i = charArray.Length - 1; i > 0; i--)
            {
                if (charArray[i] < charArray[i - 1])
                {
                    return i - 1;
                }
            }

            return -1;
        }

        private static void Swap(int index1, int index2)
        {
            var temp = _charArray[index1];
            _charArray[index1] = _charArray[index2];
            _charArray[index2] = temp;
        }
    }
}