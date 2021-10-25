using System;
using System.Collections.Generic;

namespace GenericsTestProblems
{
   public class GenericMaximum<T> where T : IComparable
        {
            public T[] value;

            public GenericMaximum(T[] value)
            {
                this.value = value;
            }

            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }

            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);
                return sorted_values[^1];
            }

            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }

            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum Value Is: " + max);
            }
    }
}
