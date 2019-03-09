using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] minListaMedSiffror = new int[5] { 25, 1, 10, 50, 40 };
            for (int i = 0; i < minListaMedSiffror.Length; i++)
            {
                Console.Write(minListaMedSiffror[i] + " ");
            }
            Console.WriteLine();

            int indexAttBytaMed = 0;
            int temporärtTal = 0;

            for (int i = 0; i < minListaMedSiffror.Length; i++)
            {
                indexAttBytaMed = i;
                for (int j = i; j < minListaMedSiffror.Length; j++)
                {
                    if (minListaMedSiffror[j] < minListaMedSiffror[indexAttBytaMed])
                        indexAttBytaMed = j;
                }

                temporärtTal = minListaMedSiffror[indexAttBytaMed];
                minListaMedSiffror[indexAttBytaMed] = minListaMedSiffror[i];
                minListaMedSiffror[i] = temporärtTal;
            }

            for (int i = 0; i < minListaMedSiffror.Length; i++)
            {
                Console.Write(minListaMedSiffror[i] + " ");

            }

        }
    }
}
