using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 112, 334, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValue();
        }
    }
}
