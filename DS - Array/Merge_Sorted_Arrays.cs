using System;

class MainClass {
    static void Main() {
        int[] arr1 = {1, 3, 5, 7}; 
        int n1 = arr1.Length; 
      
        int[] arr2 = {2, 4, 6, 8}; 
        int n2 = arr2.Length; 
      
        int[] arr3 = new int[n1+n2]; 
      
        mergeArrays(arr1, arr2, n1, n2, arr3); 
      
        Console.Write("Array after merging\n"); 
        for (int i = 0; i < n1 + n2; i++) 
            Console.Write(arr3[i] + " "); 
    }
    
    static void mergeArrays(int[] arr1, int[] arr2, int n1, int n2, int[] arr3){
        int i = 0, j = 0, k = 0; 
      
        while (i < n1 && j < n2) 
        { 
            if (arr1[i] < arr2[j]) 
                arr3[k++] = arr1[i++]; 
            else
                arr3[k++] = arr2[j++]; 
        } 
       
        while (i < n1) 
            arr3[k++] = arr1[i++]; 
      
        while (j < n2) 
            arr3[k++] = arr2[j++];
    }
}