namespace SwapElems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                
                int[] intArray = { 1, 2, 3, 4, 5 };
                Console.WriteLine("Before swap: " + string.Join(", ", intArray));
                SwapElements(intArray, 1, 3);
                Console.WriteLine("After swap: " + string.Join(", ", intArray));

              
                string[] stringArray = { "A", "B", "C", "D" };
                Console.WriteLine("Before swap: " + string.Join(", ", stringArray));
                SwapElements(stringArray, 0, 2);
                Console.WriteLine("After swap: " + string.Join(", ", stringArray));
            }
        }
        static void SwapElements<T>(T[] array, int index1, int index2)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");
            }

            if (index1 < 0 || index1 >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index1), "Index1 is out of bounds.");
            }

            if (index2 < 0 || index2 >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index2), "Index2 is out of bounds.");
            }

            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

    }
}

