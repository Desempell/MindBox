using MindBox.src.Area.Interface;
using MindBox.src.Shapes;

namespace MindBox.src.Area.Impl
{
	public class TriangleAreaCalculator : ITriangleAreaCalculator
	{
		/// <inheritdoc/>
		public double CalculateArea(Triangle entity)
		{
			CheckTriangle(entity);

			double semiperimeter = (entity.FirstSide + entity.SecondSide + entity.ThirdSide) / 2;	

			return Math.Sqrt(semiperimeter * (semiperimeter - entity.FirstSide) * (semiperimeter - entity.SecondSide) * (semiperimeter - entity.ThirdSide));
		}

		/// <inheritdoc/>
		public bool IsRectangular(Triangle triangle)
		{
			CheckTriangle(triangle);

			bool IsRectangular = false;
			if (triangle.FirstSide * triangle.FirstSide == (triangle.SecondSide * triangle.SecondSide + triangle.ThirdSide * triangle.ThirdSide)
				|| triangle.SecondSide * triangle.SecondSide == (triangle.FirstSide * triangle.FirstSide + triangle.ThirdSide * triangle.ThirdSide) 
				|| triangle.ThirdSide * triangle.ThirdSide == (triangle.FirstSide * triangle.FirstSide + triangle.SecondSide * triangle.SecondSide))
			{
				IsRectangular = true;
			}

			return IsRectangular;
		}

		private void CheckTriangle(Triangle triangle)
		{
			if ((triangle.FirstSide <= 0 || triangle.SecondSide <= 0 || triangle.ThirdSide <= 0)
				|| !((triangle.FirstSide + triangle.SecondSide > triangle.ThirdSide)
				&& (triangle.SecondSide + triangle.ThirdSide > triangle.FirstSide)
				&& (triangle.FirstSide + triangle.ThirdSide > triangle.SecondSide)))
			{
				throw new ArgumentException("Incorrect sides. The sides must be greater than 0 and the sum of the two sides must be greater than the third side");
			}
		}
	}
}
