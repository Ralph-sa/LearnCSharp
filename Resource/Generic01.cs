using System;
using System.Collections;
using System.Collections.Generic;
namespace LearnCSharp
{
    public class Generic01<T> where T : IComparable
    {
        public void BubberSort(T[] array)
        {
            int length = array.Length;
            for (int i = 0; i <= length - 2; i++)
            {
                for (int j = length - 1; j >= 1; j--)
                {
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        T temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
    public class P
    {
        int s = 1000000;
        public void UseArrayList()
        {
            double _start = 0;
            ArrayList list = new ArrayList();
            _start = DateTime.Now.Ticks;
            for (int i = 0; i < s; i++)
            {
                list.Add(i);
            }
            for (int j = 0; j < s; j++)
            {
                int value = (int)list[j];
            }
            Console.WriteLine("arraylist, time ={0} ticks", (DateTime.Now.Ticks - _start));
        }
        public void UseList()
        {
            double _start = 0;
            List<int> list = new List<int>();
            _start = DateTime.Now.Ticks;
            for (int i = 0; i < s; i++)
            {
                list.Add(i);
            }
            for (int j = 0; j < s; j++)
            {
                int value = list[j];
            }
            Console.WriteLine("list, time ={0} ticks", (DateTime.Now.Ticks - _start));
        }
    }
}