using System;

namespace SelectionSortOwn
{
    class Program
    {
        static void Main(string[] args)
        {
            Runprogram8();
        }

        private static void Runprogram8()
        {
            string[] myNumbers = { "C", "B", "A" };
            foreach (var item in myNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(true);
            Array.Sort(myNumbers);
            foreach (var item in myNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(true);
        }

        private static void Runprogram7()
        {
            double[] myNumbers = { 3.14, 5.7, 1.3, 8.45, 1.99 };
            Array.Sort(myNumbers);
            foreach (var item in myNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(true);

            double temptal = 0;
            int bytesIndex = 0;

            for (int i = 0; i < myNumbers.Length; i++)
            {
                bytesIndex = i;
                for (int j = i + 1; j < myNumbers.Length; j++)
                {
                    if (myNumbers[j] < myNumbers[bytesIndex])
                        bytesIndex = j;
                }
                temptal = myNumbers[bytesIndex];
                myNumbers[bytesIndex] = myNumbers[i];
                myNumbers[i] = temptal;
            }

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
        }

        private static void Runprogram6()
        {
            double[] myNumbers = { 3.14, 5.7, 1.3, 8.45, 1.99 };
            double temptal = 0;
            int bytesIndex = 0;

            for (int i = 0; i < myNumbers.Length; i++)
            {
                bytesIndex = i;
                for (int j = i + 1; j < myNumbers.Length; j++)
                {
                    if (myNumbers[j] < myNumbers[bytesIndex])
                        bytesIndex = j;
                }

                temptal = myNumbers[bytesIndex];
                myNumbers[bytesIndex] = myNumbers[i];
                myNumbers[i] = temptal;
            }

            foreach (var item in myNumbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void Runprogram5()
        {
            double[] myNumbers = { 3.14, 5.7, 1.3, 8.45, 1.99 };
            double temptal = 0;

            for (int i = 0; i < myNumbers.Length; i++)
            {
                int bytesIndex = i;
                for (int j = i + 1; j < myNumbers.Length; j++)
                {
                    if (myNumbers[j] < myNumbers[bytesIndex])
                        bytesIndex = j;
                }
                temptal = myNumbers[bytesIndex];
                myNumbers[bytesIndex] = myNumbers[i];
                myNumbers[i] = temptal;
            }

            foreach (var item in myNumbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void Runprogram4()
        {
            double[] myNumbers = { 3.14, 5.7, 1.3, 8.45, 1.99 };
            double temptal = 0;
            int bytesIndex = 0;

            for (int i = 0; i < myNumbers.Length; i++)
            {
                bytesIndex = i;
                for (int j = i + 1; j < myNumbers.Length; j++)
                {
                    if (myNumbers[j] < myNumbers[bytesIndex])
                        bytesIndex = j;
                }
                temptal = myNumbers[bytesIndex];
                myNumbers[bytesIndex] = myNumbers[i];
                myNumbers[i] = temptal;
            }

            foreach (var item in myNumbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void Runprogram3()
        {
            double[] myNumbers = { 3.14, 5.7, 1.3, 8.45, 1.99 };

            double tempTal = 0;
            int bytesIndex = 0;

            for (int i = 0; i < myNumbers.Length; i++)
            {
                bytesIndex = 0;
                for (int j = i + 1; j < myNumbers.Length; j++)
                {
                    if (myNumbers[j] < bytesIndex)
                        bytesIndex = j;
                }
                tempTal = myNumbers[bytesIndex];
                myNumbers[bytesIndex] = myNumbers[i];
                myNumbers[i] = tempTal;
            }

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
        }

        private static void Runprogram2()
        {
            double[] myNumbers = { 3, 5, 1, 8, 2 };

            double tempTal = 0;
            int bytesIndex = 0;

            for (int i = 0; i < myNumbers.Length; i++)
            {
                bytesIndex = i;
                for (int j = i + 1; j < myNumbers.Length; j++)
                {
                    if (myNumbers[j] < myNumbers[bytesIndex])
                        bytesIndex = j;
                }
                tempTal = myNumbers[bytesIndex];
                myNumbers[bytesIndex] = myNumbers[i];
                myNumbers[i] = tempTal;
            }

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.Write(myNumbers[i] + " ");
            }
        }

        static void Runprogram()
        {
            int[] minListaMedSiffror = new int[5] { 25, 1, 10, 50, 40 };
            for (int i = 0; i < minListaMedSiffror.Length; i++)
            {
                Console.Write(minListaMedSiffror[i] + " ");
            }
            Console.WriteLine();

            int tempTal = 0;
            int bytesIndex = 0;

            for (int i = 0; i < minListaMedSiffror.Length; i++)
            {
                bytesIndex = i;
                for (int j = i + 1; j < minListaMedSiffror.Length; j++)
                {
                    if (minListaMedSiffror[j] < minListaMedSiffror[bytesIndex])
                        bytesIndex = j;
                }
                tempTal = minListaMedSiffror[bytesIndex];
                minListaMedSiffror[bytesIndex] = minListaMedSiffror[i];
                minListaMedSiffror[i] = tempTal;
            }

            for (int i = 0; i < minListaMedSiffror.Length; i++)
            {
                Console.Write(minListaMedSiffror[i] + " ");
            }
        }
    }
}
