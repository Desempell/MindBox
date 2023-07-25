using MindBox.src.Area.Interface;
using MindBox.src.Shapes;

namespace MindBox.src.Area.Impl
{
	public class CircleAreaCalculator : ICircleAreaCalculator
	{
		/// <inheritdoc/>
		public double CalculateArea(Circle circle)
		{
			if (circle.Radius <= 0)
				throw new ArgumentException("Incorrect radius value. It must be greater than 0");

			return Math.PI * (circle.Radius * circle.Radius);
		}
	}
}
