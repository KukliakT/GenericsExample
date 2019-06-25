using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {
        public static void BubbleSort(int [] arr)
        {
         int temp = 0;
         for(int i = 0; i < arr.Length-1; i++)
            {
             for(int j = 0; j < arr.Length-1-i; j++)
                {
                  if(arr[j]>arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        
        public static void OutputArray(int[] arr)
        {
            foreach (int u in arr)
            {
                Console.Write(u + " ");
            }
            Console.WriteLine();
        }




        public static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right); //зафіксована середина

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }

        }

            static void Main(string[] args)
        {
            int[] Array = new int[] { 14, 51, 2, 9, 22, 1, 65, 11 };
            OutputArray(Array);

     
            Quick_Sort(Array, 0, Array.Length - 1);
            Console.WriteLine("Quick_Sort: ");
            OutputArray(Array);

            Console.WriteLine();
            int[] Array1 = new int[] {22, 1, 54, 27, 31, 9, 3, 25, 75, 107, 34, 68};
            OutputArray(Array1);

            BubbleSort(Array1);
             Console.WriteLine("Bubble_Sort: ");
             OutputArray(Array1);

        }
    }
}
