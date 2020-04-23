using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortingAndBinarySearch_Project
{
    public class Sorting
    {
        public int[] CreateRandomArray(int length)
        {
            int[] Array = new int[length];
            var rand = new Random();
            for (int ii = 0; ii< length; ii++)
            {
                Array[ii] = rand.Next(1, 20);
            }
            return Array;
        }
        public string PrintArray(int[] array)
        {
            string temp = "";
            for (int ii = 0; ii < array.Length; ii++)
            {

                temp += array[ii].ToString() + " ";

            }
            return temp;
        }

        public int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;               
                
            }
            return arr;
        }

        public int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        public int[] MergeSort(int[] inputArray)
        {
            return inputArray;
        }

        
    }
}
