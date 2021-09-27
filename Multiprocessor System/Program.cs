using System;
using System.Collections.Generic;

namespace Multiprocessor_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L = new List<int> { 1, 2, 1, 3, 1, 2 };
            Console.WriteLine(Multiprocessor_System(6,L,2));
        }

        static int Multiprocessor_System(int nums, List<int> pages, int MaxCacheSize)
        {
            Queue<int> q = new Queue<int>();
            int count = 0;
            for (int i = 0; i < nums; i++)
            {
                if (!q.Contains(pages[i]))
                    count++;
                if (q.Count == MaxCacheSize)
                    q.Dequeue();
               
                q.Enqueue(pages[i]);
            }
            return count;
        }
    }
}
