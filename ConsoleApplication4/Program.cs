using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void quickSort(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];

            int i = l;
            int j = r;

            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
                if (i < r)
                quickSort(a, i, r);

            if (l < j)
                quickSort(a, l, j);
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 9);
            }
            quickSort(a, 0, a.Length - 1);
                      
            foreach (int number in a)
            {
                Console.Write("{0} ", number);
            }
            Console.ReadLine();
        }
    }
}