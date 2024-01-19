namespace Math.PythagoreanTriple
{
    public class Triple
    {
        internal Triple(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string ToString()
        {
            return $"{A}^2 + {B}^2 = {C}^2";
        }

        public int A { get; }
        public int B { get; }
        public int C { get; }
    }
}