using System;

namespace InsertNumber
{
    public class BitInsert
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberSource">number into which numbers are inserted</param>
        /// <param name="numberChange">the number from which the data is taken</param>
        /// <param name="i">right border of the insert</param>
        /// <param name="j">left border of the insert</param>
        /// <returns></returns>
        public static int InsertNumber(int numberSource, int numberChange,int i ,int j)
        {

            if (i > j || i > 32 || i < 0 || j > 31 || j < 0) throw new ArgumentException();
            // j - i + 1 ones
            int segment = (2 << (j - i)) - 1;
            //insert
            return ((segment & numberChange) << i) | numberSource;
        }
    }
}
