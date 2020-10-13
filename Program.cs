using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ListSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int ListSum(List<int> x)
        {
            int total = 0
            foreach (int i in x){
                total += i;
            }
            return total
        }
        static int MaxOfList(ListSum<int> x)
        {
            int maxima = x[0];
            for (int i = 1; i < x.Count; i++)
            {
                if (x[i] > maxima)
                {
                    maxima = x[i];
                }
            }
            return maxima;
        }
        static int SumList2(ListSum<int> x)
        {
            int total = 0;
            for (int i = 0; i < x.Count; i++)
            {
                total += x[i];
            }
            return total;
        }
        //static bool SameItem(int[] x, int[] y)
        //{
        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        for (int z = 0; z < x.Length; z++)
        //        {
                            
        //        }
        //    }
        //}
    }
}
