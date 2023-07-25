using MindBox.src.Shapes;

namespace MindBox.src.Area.Interface
{
	/// <summary>
	/// Typed interface for getting the area of a figure
	/// </summary>
	/// <typeparam name="T">Shape type</typeparam>
	public interface ITypifiedCalculator<T> where T : IShape
	{
		/// <summary>
		/// Calculating the area of a shape
		/// </summary>
		/// <param name="entity">Shape</param>
		/// <returns>Shape area</returns>
		public double CalculateArea(T entity);
	}
}
