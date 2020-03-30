using System;
using System.Linq;

namespace NET.S._2020.Vakula._6
{
    public static class JaggedSort
    {
        /// <summary>
        /// swap two arrays
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        static void Swap(ref int[] arr1,ref int[] arr2)
        {
            int[] swap = arr1;
            arr1 = arr2;
            arr2 = swap;
        }
        /// <summary>
        /// Sort jugged array by sum ascending
        /// </summary>
        /// <param name="arr"></param>
        static public void SortBySumAsc(int[][] arr)
        {
            ExceptionChek(arr);
            for (int p = 0; p < arr.Length - 1; p++)
            {
                for (int i = 0; i < arr.Length - 1 - p; i++)
                {
                    if (arr[i].Sum() > arr[i + 1].Sum())
                        Swap(ref arr[i],ref arr[i + 1]);
                }
            }
        }
        /// <summary>
        /// Sort jugged array by sum descending
        /// </summary>
        /// <param name="arr"></param>
        static public void SortBySumDesc(int[][] arr)
        {
            ExceptionChek(arr);
            for (int p = 0; p < arr.Length - 1; p++)
            {
                for (int i = 0; i < arr.Length - 1 - p; i++)
                {
                    if (arr[i].Sum() < arr[i + 1].Sum())
                        Swap(ref arr[i], ref arr[i + 1]);
                }
            }
        }
        /// <summary>
        /// Sort jugged array by max element ascending
        /// </summary>
        /// <param name="arr"></param>
        static public void SortByMaxElemAsc(int[][] arr)
        {
            ExceptionChek(arr);
            for (int p = 0; p < arr.Length - 1; p++)
            {
                for (int i = 0; i < arr.Length - 1 - p; i++)
                {
                    if (arr[i].Max() > arr[i + 1].Max())
                        Swap(ref arr[i], ref arr[i + 1]);
                }
            }
        }
        /// <summary>
        /// Sort jugged array by max element descending
        /// </summary>
        /// <param name="arr"></param>
        static public void SortByMaxElemDesc(int[][] arr)
        {
            ExceptionChek(arr);
            for (int p = 0; p < arr.Length - 1; p++)
            {
                for (int i = 0; i < arr.Length - 1 - p; i++)
                {
                    if (arr[i].Max() < arr[i + 1].Max())
                        Swap(ref arr[i], ref arr[i + 1]);
                }
            }
        }
        /// <summary>
        /// Sort jugged array by min element ascending
        /// </summary>
        /// <param name="arr"></param>
        static public void SortByMinElemAsc(int[][] arr)
        {
            ExceptionChek(arr);
            for (int p = 0; p < arr.Length - 1; p++)
            {
                for (int i = 0; i < arr.Length - 1 - p; i++)
                {
                    if (arr[i].Min() > arr[i + 1].Min())
                        Swap(ref arr[i], ref arr[i + 1]);
                }
            }
        }

        /// <summary>
        /// Sort jugged array by min element descending
        /// </summary>
        /// <param name="arr"></param>

        static public void SortByMinElemDesc(int[][] arr)
        {
            ExceptionChek(arr);
            for (int p = 0; p < arr.Length - 1; p++)
            {
                for (int i = 0; i < arr.Length - 1 - p; i++)
                {
                    if (arr[i].Min() < arr[i + 1].Min())
                        Swap(ref arr[i], ref arr[i + 1]);
                }
            }
        }

        static void ExceptionChek(int[][] jarr)
        {
            if (jarr == null) throw new NullReferenceException();

            foreach(int[] arr in jarr)
            {
                if (arr == null) throw new NullReferenceException();
            }

        }



    }
}
