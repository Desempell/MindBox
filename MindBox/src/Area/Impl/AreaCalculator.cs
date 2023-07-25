using System.Reflection;
using MindBox.src.Area.Interface;
using MindBox.src.Shapes;

namespace MindBox.src.Area.Impl
{
	public class AreaCalculator : IAreaCalculator
	{
		/// <inheritdoc/>
		public double GetArea<T>(T entity) where T : IShape
		{
			var typifeidCalculatorType = Assembly.GetExecutingAssembly().GetTypes()
				.Where(x => !x.IsInterface && x.GetInterfaces()
					.Any(x => x.IsGenericType && x.GenericTypeArguments.Single() == entity.GetType()
						&& x.GetGenericTypeDefinition() == typeof(ITypifiedCalculator<>)))
				.FirstOrDefault();

			if (typifeidCalculatorType == null)
				throw new ArgumentException("This figure does not have its own area calculator");

			var typifiedCalculatorInstance = Activator.CreateInstance(typifeidCalculatorType);

			var methodForCalculateArea = typifeidCalculatorType.GetTypeInfo().GetDeclaredMethod("CalculateArea");

			var args = new object[] { entity };

			try
			{
				return (double)methodForCalculateArea.Invoke(typifiedCalculatorInstance, args);
			}
			catch (TargetInvocationException exception)
			{
				throw exception.InnerException;
			}
		}
	}
}
