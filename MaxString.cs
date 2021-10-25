using System;

namespace GenericsTestProblems
{
    class MaxString
    {

        public static string MaximumFloatNumber(string firstValue, string secondValue, string thirdValue)
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
            string a = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            string b = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            string c = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nMaximum Of 3 Integer");
            string output = MaxString.MaximumFloatNumber(a, b, c);
            Console.WriteLine(output);

        }
    }
}
