namespace MindBoxTest
{
    public class CircleCalculator
    {
        public double CircleSquare(double r)
        {
            return r*r*3.14; //не делается проверка на положителен ли радиус, так как радиус может быть и отрицательным в зависимости от начала координат и как считать. 
        }
        public double CirclePerimeter(double r)
        {
            return Math.Abs(r) * 6.28;
        }
    }
}