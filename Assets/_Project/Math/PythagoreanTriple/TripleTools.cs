using System;

namespace Math.PythagoreanTriple
{
    public static class TripleTools
    {
        private static int GetSquareSum(int first, int second)
        {
            return first * first + second * second;
        }

        private static int GetSquareDifference(int first, int second)
        {
            return first * first - second * second;
        }

        private static void CheckForLength(int first, int second)
        {
            if (first < 1 || second < 1)
            {
                throw new ArgumentException("Input must be more than zero");
            }
        }

        private static void CheckIfFirstSideIsLessThanSecond(int first, int second, string message)
        {
            if (first > second)
            {
                throw new ArgumentException(message);
            }
        }

        private static void CheckIfNotFloat(double number, string message)
        {
            if ((number % 1) != 0)
            {
                throw new ArgumentException(message);
            }
        }

        public static int FindHypotenuseWhile(int a, int b)
        {
            CheckForLength(a, b);

            CheckIfFirstSideIsLessThanSecond(a, b, "A must be less than B");

            int cc = GetSquareSum(a, b);

            int c = b + 1;
            while (c * c < cc)
            {
                c += 1;
            }
            if (c * c != cc)
            {
                throw new ArgumentException("c cannot be integer");
            }

            return c;
        }

        public static int FindHypotenuseSqrt(int a, int b)
        {
            CheckForLength(a, b);

            CheckIfFirstSideIsLessThanSecond(a, b, "A must be less than B");

            int cc = GetSquareSum(a, b);

            double c = System.Math.Sqrt(cc);

            CheckIfNotFloat(c, "C cannot be integer");

            return (int)c;
        }

        public static int FindPerpendicular(int other, int c)
        {
            CheckForLength(other, c);

            CheckIfFirstSideIsLessThanSecond(other, c, "Given side must be less than C");

            int unknownPow2 = GetSquareDifference(c, other);
            double unknown = System.Math.Sqrt(unknownPow2);

            CheckIfNotFloat(unknown, "Invalid numbers!");

            return (int)unknown;
        }

        public static bool IsTriple(int a, int b, int c)
        {
            if ((a > 0 && b > 0 && c > 0) == false) { return false; }

            int cc = GetSquareSum(a, b);

            return cc == c * c;
        }
    }
}