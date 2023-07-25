using MindBox.src.Area.Impl;
using MindBox.src.Area.Interface;
using MindBox.src.Shapes;

namespace AreaCalculateTest.Tests.Shapes.Triangles
{
	public class CheckTriangleRectangularTest
	{
		[Theory]
		[InlineData(-1, 0, 10)]
		[InlineData(0, 0, 0)]
		[InlineData(-1, -5, -10)]
		public void NotTriangle(double firstSide, double secondSide, double thirdSide)
		{
			ITriangleAreaCalculator triangleCalculator = new TriangleAreaCalculator();

			var triangle = new Triangle()
			{
				FirstSide = firstSide,
				SecondSide = secondSide,
				ThirdSide = thirdSide
			};

			Assert.Throws<ArgumentException>(() => triangleCalculator.IsRectangular(triangle));
		}

		[Theory]
		[InlineData(5, 5, 5)]
		[InlineData(8, 6, 6)]
		[InlineData(9, 6, 4)]
		public void NotRectangularTriangle(double firstSide, double secondSide, double thirdSide)
		{
			ITriangleAreaCalculator triangleCalculator = new TriangleAreaCalculator();

			var triangle = new Triangle()
			{
				FirstSide = firstSide,
				SecondSide = secondSide,
				ThirdSide = thirdSide
			};

			Assert.False(triangleCalculator.IsRectangular(triangle));
		}

		[Theory]
		[InlineData(5, 4, 3)]
		[InlineData(10, 8, 6)]
		[InlineData(12, 13, 5)]
		public void RectangularTriangle(double firstSide, double secondSide, double thirdSide)
		{
			ITriangleAreaCalculator triangleCalculator = new TriangleAreaCalculator();

			var triangle = new Triangle()
			{
				FirstSide = firstSide,
				SecondSide = secondSide,
				ThirdSide = thirdSide
			};

			Assert.True(triangleCalculator.IsRectangular(triangle));
		}
	}
}
