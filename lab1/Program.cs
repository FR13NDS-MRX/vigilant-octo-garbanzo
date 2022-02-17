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

            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}