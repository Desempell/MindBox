using MindBox.src.Area.Impl;
using MindBox.src.Area.Interface;
using MindBox.src.Shapes;

namespace AreaCalculateTest.Tests.Shapes.Circles
{
	public class CalculatingCircleAreaTest
	{
		[Theory]
		[InlineData(-1)]
		[InlineData(-10.5)]
		[InlineData(0)]
		public void IncorrectRadius(double radius)
		{
			IAreaCalculator areaCalculator = new AreaCalculator();

			var circle = new Circle() { Radius = radius };

			Assert.Throws<ArgumentException>(() => areaCalculator.GetArea(circle));
		}

		[Theory]
		[InlineData(1)]
		[InlineData(5)]
		[InlineData(10)]
		public void CorrectRadius(double radius)
		{
			IAreaCalculator areaCalculator = new AreaCalculator();

			var circle = new Circle() { Radius = radius };
			var area = Math.PI * (radius * radius);

			Assert.Equal(area, areaCalculator.GetArea(circle));
		}
	}
}
