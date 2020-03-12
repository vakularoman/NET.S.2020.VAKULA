using System;

public class Program
{
	static void QuickSort(int[] arr, int first, int last)
	{
		if (arr == null) throw new ArgumentNullException();
		if (first < last)
		{
			int border = Pivot(arr, first, last);
			QuickSort(arr, first, border - 1);
			QuickSort(arr, border + 1, last);
		}
	}
	static int Pivot(int[] arr, int first, int last)
	{
		int pivot = (first + last) / 2;
		int counter = first;
		int swap;

		for (int i = first; i <= last; i++)
		{
			if (i == pivot) continue;
			if (arr[i] < arr[pivot])
			{
				if (counter == pivot) counter++;
				swap = arr[i];
				arr[i] = arr[counter];
				arr[counter] = swap;
				counter++;
			}
		}

		if (counter > pivot) counter--;

		swap = arr[pivot];
		arr[pivot] = arr[counter];
		arr[counter] = swap;

		return counter;
	}

	static void MergeSort(int[] arr, int first, int last)
	{
		if (arr == null) throw new ArgumentNullException();

		if (first < last)
		{
			int middle = (first + last) / 2;
			MergeSort(arr, first, middle);
			MergeSort(arr, middle + 1, last);
			Merge(arr, first, last, middle);
		}
	}

	static void Merge(int[] arr, int begin, int end,int middle)
	{
		int[] tmp_arr = new int[end - begin + 1];
		int first = begin;
		int second = middle + 1;
		int id;

		for (id = 0; first<=middle && second<= end;id++)
		{
			if (arr[first] < arr[second])
			{
				tmp_arr[id] = arr[first];
				first++;
			}
			else
			{
				tmp_arr[id] = arr[second];
				second++;
			}
		}

		for (int i = id; second <= end; i++, second++)
			tmp_arr[i] = arr[second];
				
		for (int i = id; first <= middle; i++, first++)
			tmp_arr[i] = arr[first];

		for (int i = 0; i < tmp_arr.Length; i++)
			arr[begin + i] = tmp_arr[i];
	}

	public static void Main()
	{
		Random rand = new Random();

		int[][] j_array = new int[6][];
		j_array[0] = new int[1] {rand.Next(-100, 100) };

		j_array[1] = new int[100];
		for (int i = 0; i < j_array[1].Length; i++)
			j_array[1][i] = rand.Next(-100,100);
		j_array[2] = null;

		j_array[3] = new int[1] { rand.Next(-100, 100) };

		j_array[4] = new int[100];
		for (int i = 0; i < j_array[1].Length; i++)
			j_array[4][i] = rand.Next(-100, 100);
		j_array[5] = null;

		int counter = 0;

		foreach (int[] array in j_array)
		{
			if (counter == 0) Console.WriteLine("Quick Sort Algorithm");
			if (counter == j_array.Length/2) Console.WriteLine("Merge Sort Algorithm");
			try
			{
				Console.WriteLine($"\nRandom unsorted array - {string.Join(" ", array)}");
				if (counter < j_array.Length / 2) QuickSort(array, 0, array.Length - 1);
				else MergeSort(array, 0, array.Length - 1);
				Console.WriteLine($"\nSorted array - {string.Join(" ", array)}");
			}
			catch (Exception)
			{
				Console.WriteLine("\nArgumentNullException!\n");
			}
			counter++;
		}
	}
}
