using System;

namespace _12._Master_Numbers
{
    class Program
    {
        
        //Checking if the number is symetric

        static bool IsPalindrom(int num)
        {
            bool IsSymetric = true;
            string numToString = num.ToString();
            for (int i = 0; i < numToString.Length / 2; i++)
            {
                if (numToString[i] != numToString[numToString.Length - i - 1])
                {
                    IsSymetric = false;
                    break;
                }
            }
            return IsSymetric;
        }

        //Checking if the integer "num" is divisible to integer "div"

        static bool IsSumOfDigitDivisible(int num, int div)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += (num % 10);
                num /= 10;
            }

            if (sum % div == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Checking if the number is holding at least one even digit

        static bool IsHoldingEvenDigit(int num)
        {
            bool isHolding = false;
            for (int i = 0; i < num.ToString().Length; i++)
            {
                if ((num % 10) % 2 == 0)
                {
                    isHolding = true;
                    break;
                }
                else
                {
                    num = num / 10;
                }
            }
            return isHolding;
        }
        
        //Main code

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrom(i) && IsSumOfDigitDivisible(i, 7) && IsHoldingEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
