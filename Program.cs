using System;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Beginning tests of algorithms.");
            RunAllAlogorithms();
        }
        private static void RunAllAlogorithms()
        {
            int[] SELECTIONSORTARRAY = new int[] { 76, 34, 2, 45, 2, 999, -1 };
            Console.WriteLine("Selection Sort algorithm:");
            Console.WriteLine("[{0}]", string.Join(", ", SELECTIONSORTARRAY));
            SelectionSort selectionSort = new SelectionSort();
            int[] result = selectionSort.Sort(SELECTIONSORTARRAY);
            Console.WriteLine("Sorted to:");
            Console.WriteLine("[{0}]", string.Join(", ", result));

            int[] INSERTIONSORTARRAY = new int[] { 76, 34, 2, 45, 2, 999, -1 };
            Console.WriteLine("Insertion Sort algorithm:");
            Console.WriteLine("[{0}]", string.Join(", ", INSERTIONSORTARRAY));
            InsertionSort insertionSort = new InsertionSort();
            int[] insertionResult = insertionSort.Sort(INSERTIONSORTARRAY);
            Console.WriteLine("Sorted to:");
            Console.WriteLine("[{0}]", string.Join(", ", insertionResult));
        }
    }
}
