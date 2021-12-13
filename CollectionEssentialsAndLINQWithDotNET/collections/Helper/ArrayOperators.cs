namespace collections.Helper
{
    public class ArrayOperators
    {
        public void OrderBubbleSort(ref int[] array)//bubbleSort to order the array
        {
            int temp = 0;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void PritArray(int[] array)
        {
            var line = string.Join(", ", array);
            System.Console.WriteLine(line);
        }
        public void Order(ref int[] array)
        {
            Array.Sort(array);
        }
        public void Copy(ref int[] array, ref int[] destination)
        {
            Array.Copy(array, destination, array.Length);
        }
        public bool Exists(int[] array, int value)
        {
            return Array.Exists(array, element => element == value);
        }
        public bool BigThan(int[] array, int value)
        {
            return Array.TrueForAll(array, element => element > value);
        }
        public int ObtainedValue(int[] array, int value)
        {
            return Array.Find(array, element => element == value);
        }
        public int ObtainIndex(int[] array, int value)
        {
            return Array.IndexOf(array, value);
        }
        public void Resize(ref int[] array, int newSize)
        {
            Array.Resize(ref array, newSize);
        }
        public string[] ConvertingtoStringArray(int[] array)
        {
            return Array.ConvertAll(array, element => element.ToString());
        }
    }
}