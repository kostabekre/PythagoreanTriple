using System.Collections.Generic;

namespace Math.PythagoreanTriple
{
    public static class TripleCreator
    {
        public static Triple[] LoopInLimit(int limit)
        {
            var result = new List<Triple>(limit);
            for (int a = 1; a < limit; ++a)
            {
                int aa = a * a;
                int b = a + 1;
                int c = b + 1;
                while (c <= limit)
                {
                    int cc = aa + b * b;
                    while (c * c < cc) { ++c; }
                    if (c * c == cc && c <= limit)
                    {
                        result.Add(new Triple(a, b, c));
                    }
                    ++b;
                }
            }
            return result.ToArray();
        }
    }
}