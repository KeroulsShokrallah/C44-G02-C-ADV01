using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_C_ADV01
{
    internal class helper
    {
        public static void Swap <T> (ref T n1 , ref T n2 )
        {
            T temp = n1;
            n1 = n2;
            n2 = temp;
        }
        public static void OptimizedBubbleSort<T>(T[] array)  where T  : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0;  j<array.Length-i-1; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        Swap(ref array[j], ref array[j+1]);
                    }
                }
            }
        }
    }
}
