using System.Data;

namespace TotallySafeLib
{
    public class TotallySafe
    {
        public static double Divider(int number)
        {
            return 7 / number;
        }
        public static int StringToInt(string stringToConvert)
        {
            return int.Parse(stringToConvert);
        }
        public static int GetValueAtPosition(int positionInArray)
        {
            if (positionInArray < 0) {
                throw new NegativeIndexOutOfRangeException("Can't use a negative number as an index"); 
            }
            int[] intArray = { 1, 2, 3, 4, 5 };
            return intArray[positionInArray];
        }
    }
    
}
