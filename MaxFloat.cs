using System;

namespace GenericsTestProblems
{
    class MaxFloat
    {

        public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }


            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
               secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
               secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }


            if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0 ||
               thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
               thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                return thirdValue;
            }
            return firstValue;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nMaximum Of 3 Integer");
            double output = MaxFloat.MaximumFloatNumber(a, b, c);
            Console.WriteLine(output);

        }
    }
}
