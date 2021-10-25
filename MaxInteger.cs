using System;

namespace GenericsTestProblems
{
    class MaxInteger
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
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
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMaximum Of 3 Integer");
            int output = MaxInteger.MaximumIntegerNumber(a, b, c);
            Console.WriteLine(output);

        }
    }
}
