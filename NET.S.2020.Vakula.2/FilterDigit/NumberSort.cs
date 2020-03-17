using System;
using System.Collections.Generic;

namespace FilterDigit
{
    public static class NumberSort
    {
        /// <summary>
        /// function returns numbers which
        /// contains first element of the list
        /// </summary>
        /// <param name="list">list of elements</param>
        public static void FilterDigit(List<int> list)
        {
            if (list == null) throw new ArgumentNullException();
            if (list.Count == 0) throw new ArgumentException();
            //first element is number for sorting
            string number = list[0].ToString();
            list.RemoveAt(0);
            //sort
            for (int i = 0; list.Count > i; i++)
            {
                if (!list[i].ToString().Contains(number))
                {
                    list.RemoveAt(i);
                    i--;
                }

            }
        }
    }
}
