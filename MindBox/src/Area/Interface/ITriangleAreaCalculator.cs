using MindBox.src.Shapes;

namespace MindBox.src.Area.Interface
{
	/// <inheritdoc/>
	public interface ITriangleAreaCalculator : ITypifiedCalculator<Triangle>
	{
		/// <summary>
		/// Checking a triangle for rectangularity
		/// </summary>
		/// <returns>Triangle rectangularity</returns>
		bool IsRectangular(Triangle triangle);
	}
}
