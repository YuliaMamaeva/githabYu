using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            CreateArray(arr);
            Swap(arr);
            Console.WriteLine("***********");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {arr[i]}");
            }
            Console.WriteLine("***********");
            GetMinMax(arr);
            Console.WriteLine("***********");
            BubbleSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {arr[i]}");
            }
        }

        static void CreateArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Array[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

        }
        static void GetMinMax(int[] array)
        {
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];
                if (min > array[i]) min = array[i];
            }
            Console.WriteLine($"Max - Min = {max - min}");
        }
        static void Swap(int[] array)
        {
            if (array.Length <= 1) return;

            int min = 0, max = 0;
            for (var i = 1; i < array.Length; i++)
                if (array[i] > array[max])
                    max = i;
                else if (array[i] < array[min])
                    min = i;

            var temp = array[min];
            array[min] = array[max];
            array[max] = temp;
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
    }
}
