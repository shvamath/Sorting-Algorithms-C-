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
        public static void MergeSort(double[] ar, int Lborder, int Rborder)
        {
        }
        public static void MergeSort(int[] ar, int Lborder, int Rborder)
        {
        }
        public static int BinarySearch(double[] ar)
        {
            int l, m, h;
            l = 0;
        }
    }
}
