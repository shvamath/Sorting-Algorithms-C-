using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class Class1
    {
        public static void QuickSort(double[] ar, int Lborder, int Rborder)
        {
            double temp;
            double x = ar[Lborder + (Rborder - Lborder) / 2];
            int i = Lborder; int j = Rborder;
            while (i < j)
            {
                while (ar[i] < x) i++;
                while (ar[j] > x) j--;
                if (i <= j)
                { temp = ar[i]; ar[i] = ar[j]; ar[j] = temp;
                    i++; j--;
                }
            }
            if (i < Rborder) QuickSort(ar, i, Rborder);
            if (Lborder < j) QuickSort(ar, Lborder, j);
        }
        public static void QuickSort(int[] ar, int Lborder, int Rborder)
        {
            int temp;
            int x = ar[Lborder + (Rborder - Lborder) / 2];
            int i = Lborder; int j = Rborder;
            while (i < j)
            {
                while (ar[i] < x) i++;
                while (ar[j] > x) j--;
                if (i <= j)
                {
                    temp = ar[i]; ar[i] = ar[j]; ar[j] = temp;
                    i++; j--;
                }
            }
            if (i < Rborder) QuickSort(ar, i, Rborder);
            if (Lborder < j) QuickSort(ar, Lborder, j);
        }
        public static void BubbleSort(double[] ar, int Lborder, int Rborder)
        {
            double temp;
            for (int i = Lborder; i <= Rborder; i++)
                for (int j = Rborder; j > i ; j--)
                    if (ar[j] < ar[j - 1])
                    {
                        temp = ar[j];
                        ar[j] = ar[j - 1];
                        ar[j - 1] = temp;
                    }
        }
        public static void BubbleSort(int[] ar, int Lborder, int Rborder)
        {
            int temp;
            for (int i = Lborder; i <= Rborder; i++)
                for (int j = Rborder; j > i; j--)
                    if (ar[j] < ar[j - 1])
                    {
                        temp = ar[j];
                        ar[j] = ar[j - 1];
                        ar[j - 1] = temp;
                    }
        }
        public static int[] MergeSort(int[] ar)
        {
            if (ar.Length == 1) return ar;
            int mid =ar.Length / 2;
            return Merge(MergeSort(ar.Take(mid).ToArray()),
                   MergeSort(ar.Skip(mid).ToArray()));
        }
        private static int[] Merge (int[] ar1, int[] ar2)
        {
            int a = 0, b = 0;
            int[] merged = new int[ar1.Length + ar2.Length];
            for (int i = 0; i<merged.Length; i++)
            {
                if (b < ar2.Length && a < ar1.Length)
                    if (ar1[a] > ar2[b]) merged[i] = ar2[b++];
                    else merged[i] = ar1[a++];
                else
                    if (b < ar1.Length) merged[i] = ar2[b++];
                    else merged[i] = ar1[a++];   
            }
            return merged;
        }
        public static void InsertionSort(int[] ar)
        {
            int i, j, c;
            for (i=1; i<ar.Length; i++)
            {
                c = ar[i];
                j = i - 1;
                while (j >= 0 && ar[j] > c)
                {
                    ar[j + 1] = ar[j];
                    j--;
                }
                ar[j + 1] = c;
            }
        }
        public static void BinaryInsertionSort(int[] ar)
        {
            int i, j, left, right, m, x;
            for (i = 1; i < ar.Length; i++)
                if (ar[i - 1] > ar[i])
                {
                    x = ar[i];
                    left = 0;
                    right = i - 1;
                    do
                    {
                        m = (left + right) / 2;
                        if (ar[m] < x) left = m + 1;
                        else right = m - 1;
                    }
                    while (left <= right);
                    for (j = i - 1; j > -left; j--) ar[j + 1] = ar[j];
                    ar[left] = x;
                }
        }
        public static void ShellSort(int[] ar)
        {
            int step, i, j, c;
            step = ar.Length;
            do
            {
                step = step / 3 + 1; //calculating new step
                for (i = step; i < ar.Length; i++)
                {
                    c = ar[i];
                    j = i - step;
                    while (j >= 0 && ar[j] > c)
                    {
                        ar[j + step] = ar[j];
                        j = j - step;
                    }
                    ar[j + step] = c;
                }
            }
            while (step != 1);
        }
        public static int BinarySearch(int[] ar, int search_key)
        {
            int l, m, h;
            l = 0;
            h = ar.Length-1;
            while (l < h)
            {
                m = (l + h) / 2;
                if (ar[m] < search_key) l = m + 1;
                else h = m;
            }
            if (ar[l] == search_key) return l;
            else return -1; 
        }
        public static void CountingSort(int[] ar)
        {

        }
        public static void BucketSort()
    }
}
