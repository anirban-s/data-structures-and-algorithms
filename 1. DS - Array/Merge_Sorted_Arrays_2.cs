using System;

class MainClass
{
  static int[] MergeSortedArrays(int[] array1, int[] array2)
  {
    int[] result = new int[array1.Length + array2.Length];

    int array1Item = array1[0];
    int array2Item = array2[0];
    int i = 0;
    int j = 1;
    int k = 1;

    while (i < result.Length)
    {
      if(array1Item > -1 && (array1Item < array2Item || array2Item < 0))
      {
        result[i] = array1Item;
        if(j < array1.Length)
        {
          array1Item = array1[j];
          j++;
        }
        else
        {
          array1Item = -1;
        }
      }
      else
      {
        result[i] = array2Item;
        if (k < array2.Length)
        {
          array2Item = array2[k];
          k++;
        }
        else
        {
          array2Item = -1;
        }
      }

      i++;
    }
    
    return result;
  }
  // 0, 3, 4, 4, 6, 30, 31
  
  
  static void Main()
  {
    int[] array1 = new int[] {0, 3, 4, 31};
    int[] array2 = new int[] {4, 6, 30};
    // int[] array2 = new int[] {4, 6, 30, 32, 34};

    int[] newArray = MergeSortedArrays(array1, array2);

    foreach(int item in newArray)
    {
      Console.Write(item.ToString() + "  ");
    }
  }
}
