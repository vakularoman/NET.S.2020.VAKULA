using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace GCD
{
	public class GCD
	{
		/// <summary>
		/// find Greatest common divisor of two
		/// or more numbers
		/// </summary>
		/// <param name="arr">list of numbers</param>
		/// <param name="time">elapsed time</param>
		/// <returns></returns>
		static public int Euclid(List<int> arr, out double time)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			if (arr == null) throw new ArgumentNullException();
			if (arr.Count < 2) throw new ArgumentException();

			arr = arr.Select(x => Math.Abs(x)).Where(x => x != 0).ToList();

			while (arr.Max() != arr.Min())
			{
				//all elements(except min element) - min element
				arr = ((from el in arr
						where el > arr.Min()
						select el - arr.Min()).
					 Concat(from cust in arr
							where cust == arr.Min()
							select cust)).ToList();

				if (arr.Min() == 1) break;
			}
			stopwatch.Stop();
			time = stopwatch.ElapsedMilliseconds;
			return arr.Min();
		}

		static public int Stain(List<int> arr, out double time)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			if (arr == null) throw new ArgumentNullException();
			if (arr.Count < 2) throw new ArgumentException();

			int k = 1;

			arr = arr.Select(x => Math.Abs(x)).Where(x => x != 0).ToList();

			while (arr.Max() != arr.Min())
			{
				//x%2 && y%2 == 0 
				while (arr.Select(x => x).Where(x => x % 2 != 0).Count() == 0)
				{
					arr = arr.Select(x => x >> 1).ToList();
					k <<= 1;
				}
				//x%2 || y%2 == 0 
				while (arr.Select(x => x).Where(x => x % 2 == 0).Count() != 0)
				{
					arr = ((from el in arr
							where el % 2 == 0
							select el >> 1).
					 Concat(from el in arr
							where el % 2 != 0
							select el)).ToList();
				}
				//x-y || y - x
				arr = ((from el in arr
						where el > arr.Min()
						select el - arr.Min()).
					 Concat(from el in arr
							where el == arr.Min()
							select el)).ToList();

				arr = arr.Select(x => x).Where(x => x != 0).ToList();

				if (arr.Min() == 1) break;
			}
			stopwatch.Stop();
			time = stopwatch.ElapsedMilliseconds;
			return arr.Min() * k;
		}
	}
}
