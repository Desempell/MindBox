using MindBox.src.Shapes;

namespace MindBox.src.Area.Interface
{
	/// <summary>
	/// Interface for getting the area of a figure
	/// </summary>	
	/// <exception cref="ArgumentException">Incorrect values of shape properties or non-existence of a calculator for a shape</exception>
	public interface IAreaCalculator
	{
		/// <summary>
		/// Getting the area of a shape
		/// </summary>
		/// <param name="entity">Shape</param>
		/// <returns>Shape area</returns>
		public double GetArea<T>(T entity) where T : IShape;
	}
}
