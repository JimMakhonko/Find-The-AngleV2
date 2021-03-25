using System;

namespace FindTheAngleV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to find out the angle: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int degree = GetDegree(x);
            Console.WriteLine("Degree is " + degree);
        }

        private static int GetDegree(int x)
        {
            int y = x % 12;
            int degree = NormalizedNumber(y) * 30;
            return degree;
        }

        public static int NormalizedNumber(int number)
        {
            if (number > 6)
            {
                return 12 - number;
            }
            return number;
        }
    }
}