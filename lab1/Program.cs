using System;

namespace Lab1
{

    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int cashboxCount = n;

            if (customers.Length < cashboxCount)
            {
                cashboxCount = customers.Length;
            }

            int[] threads = new int[cashboxCount];

            for (int j = 0; j < cashboxCount; j++)
            {
                threads[j] = customers[j];
            }

            int totalTime = 0;
            int i = cashboxCount;

            while (i < customers.Length)
            {
                int min = threads[0];

                for (int j = 1; j < cashboxCount; j++)
                {
                    if (threads[j] < min)
                    {
                        min = threads[j];
                    }
                }

                for (int j = 0; j < cashboxCount; j++)
                {
                    threads[j] -= min;
                }
                totalTime += min;

                for (int j = 0; j < cashboxCount; j++)
                {
                    if (threads[j] == 0 && i < customers.Length)
                    {
                        threads[j] = customers[i];
                        i++;
                    }
                }
            }

            int max = 0;

            for (int j = 0; j < cashboxCount; j++)
            {
                if (threads[j] > max)
                {
                    max = threads[j];
                }
            }

            return totalTime + max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] q1 = { 5, 3, 4 };
            Console.WriteLine(HW1.QueueTime(q1, 1));
            int[] q2 = { 10, 2, 3, 3 };
            Console.WriteLine(HW1.QueueTime(q2, 2));
            int[] q3 = { 2, 3, 10 };
            Console.WriteLine(HW1.QueueTime(q3, 2));
            int[] q4 = { 533, 43, 10 };
            Console.WriteLine(HW1.QueueTime(q4, 4));
            int[] q5 = { 55 };
            Console.WriteLine(HW1.QueueTime(q5, 1));
            int[] q6 = { };
            Console.WriteLine(HW1.QueueTime(q6, 3));
            int[] q7 = { 5, 5, 5, 2 };
            Console.WriteLine(HW1.QueueTime(q7, 3));
        }
    }
}