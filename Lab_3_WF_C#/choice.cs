using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Sort
{
    public class Choice
    {
        public Choice() { }
        public double[] Sort(List<double> arr)
        {
            int c = 0; // количество операций сравнения элементов массива
            int m = 0; // количество перестановок элементов массива
            int n = arr.Count; // количество элементов в таблице

            //создаем объект
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                    c++;
                }

                if (minIndex != i)
                {
                    double temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                    m++;
                }
            }

            //останавливаем счётчик
            stopwatch.Stop();

            return new double[] { stopwatch.Elapsed.TotalSeconds, (double)c / n, (double)m / n };
        }
    }

    public class Insert
    {
        public Insert() { }
        // Сортировка элементов методом вставки
        public double[] Sort(List<double> arr)
        {
            int c = 0; // количество операций сравнения элементов массива
            int m = 0; // количество перестановок элементов массива
            int n = arr.Count; // количество элементов в таблице

            //создаем объект
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();

            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                double value = arr[i];
                bool flag = true;
                while (j >= 0 && arr[j] > value )
                {
                    c++;
                    m++;
                    double temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                    j--;
                    flag = false;
                }
                if (flag)
                {
                    c++;
                }
            }

            //останавливаем счётчик
            stopwatch.Stop();

            return new double[] { stopwatch.Elapsed.TotalSeconds, (double)c / n, (double)m / n };
        }
    }
    public class Exchange
    {
        public Exchange() { }
        public double[] Sort(List<double> arr)
        {
            int c = 0; // количество операций сравнения элементов массива
            int m = 0; // количество перестановок элементов массива
            int n = arr.Count; // количество элементов в таблице

            //создаем объект
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();

            for (int i = 0; i < n - 1; i++) 
            {
                for (int j = i + 1; j < n; j++) 
                {
                    if (arr[j] < arr[i] && c++ > -1)
                    {
                        m++;
                        double temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            //останавливаем счётчик
            stopwatch.Stop();

            return new double[] { stopwatch.Elapsed.TotalSeconds, (double)c / n, (double)m / n };

        }
    }

    public class Partience 
    { 
        public Partience() { } 
        
        public double[] Sort(List<double> arr)
        {
            int n = arr.Count; // количество элементов в таблице
            List<List<double>> deck = new List<List<double>>(); // колоды для сортировки
            List<double> arr_sort = new List<double>();
            //создаем объект
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();

            deck.Add( new List<double>() { arr[0] });

            // перебираем элементы массива
            for (int i = 1; i < n; i++) 
            {
                bool flag = true; 
                // перебираем колоды
                for (int j = 0; j < deck.Count; j++)
                {
                    // если элемент меньше или равен последниму элементу колоды
                    if (arr[i] <= deck[j].Last())
                    {
                        deck[j].Add(arr[i]);
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    deck.Add(new List<double>() { arr[i] });
                }

            }

            arr.Clear();
            double a = -1.0;
            int index = 0;
            while (true)
            {
                for (int i = 0; i < deck.Count; i++)
                {
                    if (a == -1.0 && deck[i].Count != 0)
                    {
                        a = deck[i].Last();
                        index = i;
                    }
                    else if (deck[i].Count != 0 && a >= deck[i].Last())
                    {
                        a = deck[i].Last();
                        index = i;
                    }
                }
                if (a == -1.0)
                {
                    break;
                }
                arr.Add(a);
                a = -1.0;
                deck[index].RemoveAt(deck[index].Count - 1);
            }

            //останавливаем счётчик
            stopwatch.Stop();

            return new double[] { stopwatch.Elapsed.TotalSeconds, 0.0, 0.0 };

        }
    }

    public class Quick
    {
        public Quick() { }
        public double[] Sort(List<double> arr, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = arr[leftIndex];
            //создаем объект
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();

            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                Sort(arr, leftIndex, j);

            if (i < rightIndex)
                Sort(arr, i, rightIndex);

            //останавливаем счётчик
            stopwatch.Stop();

            return new double[] { stopwatch.Elapsed.TotalSeconds, 0.0, 0.0 };
        }
    }

    public class Comb
    { 
        public Comb() { }
        public double[] Sort(List<double> arr)
        {
            double gap = arr.Count();
            bool swaps = true;

            //создаем объект
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();

            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < arr.Count())
                {
                    int igap = i + (int)gap;
                    if (arr[i] > arr[igap])
                    {
                        double temp = arr[i];
                        arr[i] = arr[igap];
                        arr[igap] = temp;
                        swaps = true;
                    }
                    i++;
                }
            }
            //останавливаем счётчик
            stopwatch.Stop();
            return new double[] { stopwatch.Elapsed.TotalSeconds, 0.0, 0.0 };

        }
    }
}
