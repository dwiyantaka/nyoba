using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanKos1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 120, 3, 453, 50, 54, 75, 60, 9, 100, 13 };
            int temp = 0;

            for (int i = 0; i< arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if(arr[j] > arr [j+1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int k = 0; k < arr.Length; k++)           
                Console.Write(arr[k] + " ");
            Console.ReadKey();
        }
    }
}
