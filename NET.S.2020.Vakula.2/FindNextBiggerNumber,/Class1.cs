using System;
using System.Collections.Generic;

namespace FindNextBiggerNumber
{
    public static class BiggerNumber
    {
        /// <summary>
        /// find next bigger number which
        /// consists of elenets of initial number
        /// </summary>
        /// <param name="number">initial number</param>
        /// <returns></returns>
        public static Tuple<int,double> FindNextBiggerNumber(int number)
        {
            DateTime initial_time = DateTime.Now;

            if (number <= 0) throw new ArgumentException();

            int[] array = new int[number.ToString().Length];
            //int into array
            for (int i = array.Length - 1; i >=0 ;i--)
            {
                array[i] = number % 10;
                number /= 10;
            }

            List<int> list = new List<int>();

            int min = int.MaxValue;
            int index = 0;
            int result = 0;

            //try to make number greater
            for(int i = array.Length - 2;i >= 0; i--)
            {
                //elemets > array[i]
                for(int j = array.Length - 1; j > i; j--)
                {
                    if (array[i] < array[j]) list.Add(j);
                }

                if (list.Count == 0) continue;
                //min element from elemets > array[i]
                foreach (int l in list)
                {
                    if (min >= array[l])
                    {
                        min = array[l];
                        index = l;
                    }
                }

                array[index] = array[i];
                array[i] = min;

                //minimize number
                for (int k = i + 1; k < array.Length - 1; k++)
                {
                    for (int j = k + 1; j < array.Length; j++)
                    {
                        if (array[k] > array[j])
                        {
                            min = array[j];
                            array[j] = array[k];
                            array[k] = min;
                        }
                    }
                }
                //array into int
                for (int k = 0; k < array.Length; k++)
                {
                    result += array[k];
                    result *= 10;
                }

                return Tuple.Create(result/10, (DateTime.Now - initial_time).TotalMilliseconds);

            }

            return Tuple.Create(-1, (DateTime.Now - initial_time).TotalMilliseconds);
        }
    }
}
