using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_C_ADV01
{
    internal class Range<T>where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }




        #region 2.Implement a constructor that takes the minimum and maximum values to define the range.

        public Range(T min , T max)
        {
            if (min .CompareTo (max) > 0)
            {
                T temp = min;
                min = max;
                max = temp;
                //throw new ArgumentException("min should less than max");
            }
            
            Min = min;
            Max = max;
        }
        #endregion


        #region 3.Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.


        public  bool IsInRang(T value )
        {
          return   value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;

        }


        #endregion


        #region 4.Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).


        public double Length()
        {

            dynamic minvalue = Min;
            dynamic maxvalue = Max;

            return maxvalue - minvalue;


        }
        #endregion

        public override string ToString()
        {
            return $"min = {Min}  ... max = {Max}";
        }
    }
}
