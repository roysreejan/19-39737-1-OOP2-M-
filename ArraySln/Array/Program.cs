using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //read n number and display reverse order
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array in reverse order: ");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
           Console.WriteLine();


            //sum of all elements of the array
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum of all elements of the array: {0}" , sum);
            Console.WriteLine();


            //copy to another array
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("Elements of new array: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();


            //total number of duplicate value
            int[] arr3 = {5, 3, 5, 8, 6, 3, 9, 3 };
            
            for (int i = 0; i < arr3.Length; i++)
            {
                int count = 0;
                for (int j = i; j < arr3.Length; j++)
                {

                    if (arr3[i] == arr3[j])
                    {
                        count=count+1;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Total number of duplicate elements in an array:" + count);
            }


            //print all unique elements in an array
            

        }
    }
}