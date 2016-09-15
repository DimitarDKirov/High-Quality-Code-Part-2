using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        if (arr == null | arr.Length == 0)
        {
            throw new ArgumentNullException("Input array must not be null or empty");
        }

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) where T : IComparable<T>
    {
        Debug.Assert(arr != null && arr.Length > 0, "Input array can not be null or empty");
        Debug.Assert(0 <= startIndex && startIndex < arr.Length, "Start index must be between 0 and )array length -1");
        Debug.Assert(startIndex <= endIndex && endIndex < arr.Length, "End index must be between start index and array length - 1");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(0 <= minElementIndex && minElementIndex < arr.Length, "Min element index must be between 0 and array length-1");
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {

        if (arr == null | arr.Length == 0)
        {
            throw new ArgumentNullException("Input array must not be null or empty");
        }

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) where T : IComparable<T>
    {
        Debug.Assert(arr != null && arr.Length > 0, "Array can not be null or empty");
        Debug.Assert(0 <= startIndex && startIndex < arr.Length, "Start index must be between 0 and )array length -1");
        Debug.Assert(startIndex <= endIndex && endIndex < arr.Length, "End index must be between start index and array length - 1");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                Debug.Assert(0 <= midIndex && midIndex < arr.Length, "Found element index must be between 0 and array length-1");
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        //SelectionSort(new int[0]); // Test sorting empty array
        //SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));

        SelectionSort(new int[0]);
    }
}
