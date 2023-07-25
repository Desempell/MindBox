using MindBox.src.Area.Impl;
using MindBox.src.Area.Interface;
using MindBox.src.Shapes;

namespace AreaCalculateTest.Tests.Shapes.Triangles
{
	public class CalculatingTriangleAreaTest
	{
		[Theory]
		[InlineData(-1, 0, 10)]
		[InlineData(0, 0, 0)]
		[InlineData(-1, -5, -10)]
		public void IncorrectSides(double firstSide, double secondSide, double thirdSide)
		{
			IAreaCalculator areaCalculator = new AreaCalculator();

			var triangle = new Triangle()
			{
				FirstSide = firstSide,
				SecondSide = secondSide,
				ThirdSide = thirdSide
			};

			Assert.Throws<ArgumentException>(() => areaCalculator.GetArea(triangle));
		}

		[Theory]
		[InlineData(2, 5, 4)]
		[InlineData(3, 6, 8)]
		[InlineData(5, 5, 7)]
		public void CorrectSides(double firstSide, double secondSide, double thirdSide)
		{
			IAreaCalculator areaCalculator = new AreaCalculator();

			var triangle = new Triangle()
			{
				FirstSide = firstSide,
				SecondSide = secondSide,
				ThirdSide = thirdSide
			};

			double semiperimeter = (firstSide + secondSide + thirdSide) / 2;

			var area = Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));

			Assert.Equal(area, areaCalculator.GetArea(triangle));
		}
	}
}
