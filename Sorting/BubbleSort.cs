using System;

class BubbleSort
{
    public static int[] bubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }

    static void Main(string[] args)
    {
        int[] array = {8, 1, 56, 4, 7, 1, 87, 0};
        foreach (var item in bubbleSort(array))
        {
            Console.WriteLine(item);
        }
    }
}