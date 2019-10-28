using System;

namespace Open_Lab_02._7
{
    class Program
    {
        public static bool IsTimeForMilkAndCookies(int month, int day)
        {
            if (month == 12 && day == 24)
            {
                return true;
            }
            else
            {
                return !true;
            }
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Enter day");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter month");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(IsTimeForMilkAndCookies(b, a));
        }
    }
}

