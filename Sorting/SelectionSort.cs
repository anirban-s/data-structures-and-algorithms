using System;

class SelectionSort
{
    public static int[] selectionSort(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            int min = i;
            int temp = array[i];
            for (int j = i + 1; j < length; j++)
            {
                if (array[j] < array[min])
                { //Searching min value and it's index
                    min = j;
                }
            }
            
            array[i] = array[min];
            array[min] = temp;
        }
        return array;
    }

    static void Main(string[] args)
    {
        int[] array = { 8, 1, 56, 4, 7, 1, 87, 0 };
        foreach (var item in selectionSort(array))
        {
            Console.WriteLine(item);
        }
    }
}