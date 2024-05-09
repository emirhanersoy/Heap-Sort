using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    public class Program
    {
        public static void maxheapify(int[] array, int i) {

            int left, right, largest, temp;

            left = 2*i+1;
            right = 2*i+2;


            if(left < array.Length && array[left] > array[i])
            {
                largest = left;
            }

            else
            {
                largest = i;
            }
            if (right < array.Length && array[right] > array[largest])
            {
                largest = right;
            }


            if (largest != i)
            {
                temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;
                maxheapify(array, largest);
            }

            
        }

        public static void buildmaxheap(int[] array)
        {
            int i, n;
            n= array.Length;

            for(i=(n/2)+1; i>=0; i--)
            {
                maxheapify(array, i);
            }
        }

        public static void heapsort(int[] array)
        {
            buildmaxheap(array);

            int i, n, temp;
            n = array.Length;

            for (i = n - 1; i > 0; i--) // Loop until second-to-last element
            {
                temp = array[i];
                array[i] = array[0];
                array[0] = temp;

                maxheapify(array, 0);
            }
            n--; // Decrement n after the last swap
        }
        static void Main(string[] args)
        {

            int[] array = { 1,6,2,15,3,4 };

            heapsort(array);

            foreach(int i in array)
            {
                 Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
