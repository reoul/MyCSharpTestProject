using System;
using System.Collections.Generic;
using System.Linq;

namespace MyUtil
{
    public static class SorterUtil<T>
    {
        public static void SortAndShow(IEnumerable<T> enumerator, Comparison<T>? comparison = null)
        {
            List<T> list = enumerator.ToList();

            if (comparison == null)
                list.Sort();
            else
                list.Sort(comparison);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i].ToString());

            const int aa = 10;


        }

        /*public static void SortAndShow(IEnumerable<T> enumerator, Comparison<T>? comparison = null)
        {
            List<T> list = enumerator.ToList();

            if (comparison == null)
                list.Sort();
            else
                list.Sort(comparison);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i].ToString());
        }*/
    }
}
