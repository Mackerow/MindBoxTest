using NUnit.Framework;
using MindBoxTest;
namespace MindBoxUnitTests
{
    public class Tests
    {
        [Test]
        public void CircleSquare_Radius_3()
        {
            double radius = 3;
            CircleCalculator circleCalculator = new CircleCalculator();
            double result = circleCalculator.CircleSquare(radius);
            Assert.AreEqual(result, 28.26);
        }
        [Test]
        public void CircleSquare_Radius_Neg3()
        {
            double radius = -3;
            CircleCalculator circleCalculator = new CircleCalculator();
            double result = circleCalculator.CircleSquare(radius);
            Assert.AreEqual(result, 28.26);
        }
        [Test]
        public void CirclePerimeter_Radius_3dot14()
        {
            double radius = 3.14;
            CircleCalculator circleCalculator = new CircleCalculator();
            double result = circleCalculator.CirclePerimeter(radius);
            Assert.AreEqual(result, 19.7192);
        }
        [Test]
        public void CirclePerimeter_Radius_Neg3dot14()
        {
            double radius = -3.14;
            CircleCalculator circleCalculator = new CircleCalculator();
            double result = circleCalculator.CirclePerimeter(radius);
            Assert.AreEqual(result, 19.7192);
        }
        [Test]
        public void TriangleIsRectangular_3_4_5()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            TrianlgeCalculator trianlgeCalculator = new TrianlgeCalculator();
            Assert.AreEqual(true, trianlgeCalculator.IsRectangular(a, b, c));
        }
        [Test]
        public void TriangleIsRectangular()
        {
            int a = 5;
            int b = 5;
            int c = 5;
            TrianlgeCalculator trianlgeCalculator = new TrianlgeCalculator();
            Assert.AreEqual(false, trianlgeCalculator.IsRectangular(a, b, c));
        }
        [Test]
        public void TriangleSquare_3_4_5()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            TrianlgeCalculator trianlgeCalculator = new TrianlgeCalculator();
            Assert.AreEqual(6, trianlgeCalculator.TriangleSquare(a, b, c));
        }
        [Test]
        public void TriangleSquare_10_12_13()
        {
            int a = 12;
            int b = 13;
            int c = 10;
            TrianlgeCalculator trianlgeCalculator = new TrianlgeCalculator();
            Assert.AreEqual(56.995065575889988d, trianlgeCalculator.TriangleSquare(a, b, c));
        }
    }
}