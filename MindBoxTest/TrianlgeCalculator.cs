
namespace MindBoxTest
{
    public class TrianlgeCalculator
    {
        public double TriangleSquare(double A, double B, double C)
        {
            A=Math.Abs(A);
            B=Math.Abs(B);
            C=Math.Abs(C);
            if (C >= A + B || B >= A + C || A >= B + C)
            {
                throw new Exception("Треугольник не существует");
            }
            else
            {
                return Math.Sqrt((A + B + C) * (A + B - C) * (A + C - B) * (B + C - A) / 16);
            }
        }
        public bool IsRectangular (int a, int b, int c)
        {
            return a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a;
        }
    }
}
