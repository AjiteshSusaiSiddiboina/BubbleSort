using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter the number of elements : ");

            try
            {
                int size = int.Parse(Console.ReadLine());

                int[] arr = new int[size];

                for(int i = 0 ; i < arr.Length ; i++ )
                    arr[i] = int.Parse(Console.ReadLine());

                var p = new Program();


                for (int i = 0; i < arr.Length; i++)
                    for (int j = 0; j < arr.Length - i - 1; j++)
                        if (arr[j] > arr[j + 1])
                            p.Swap(ref arr[j], ref arr[j + 1]);


                foreach (var v in arr)
                    Console.WriteLine(v);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nException caught : " + ex.Message);
            }

            Console.Read();
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
