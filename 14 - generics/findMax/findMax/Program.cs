using System;

namespace findMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            FindMax(arr);
        }


        public static Thing FindMax<Thing>(Thing[] arr) where Thing : IComparable<Thing>
        {
            Thing max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i]; break;
                }
            }
            return max;
        }
    }
}
