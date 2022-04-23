using System;
using System.Collections.Generic;
using System.Text;

namespace SortingWithoutArray
{
    internal class Class1
    {
        public static void sorting()
        {
            Console.WriteLine("Enter 1st Number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1st Number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1st Number:");
            int num3 = int.Parse(Console.ReadLine());

            int small=0, middle=0, large=0;

            if (num1< num2 && num1<num3)
            {
               small = num1;
                if (num2 < num3)
                {
                    middle = num2;
                    large = num3;
                }
                else
                {
                    middle = num3;
                    large = num2;
                }
            }

            if (num2<num1 && num2<num3)
            {
                small = num2;
                if (num1 < num3)
                {
                    middle = num1;
                    large = num3;
                }
                else
                {
                    middle = num3;
                    large = num1;
                }
            }
            if(num3<num1 && num3<num2)
            {
                small = num3;
                if (num2 < num1)
                {
                    middle = num2;
                    large = num1;
                }
                else
                {
                    middle = num1;
                    large = num2;
                }
            }
            Console.WriteLine("Sorted Number Is: {0} {1} {2}", small, middle, large);
            Console.ReadLine();
        }

    }
}
