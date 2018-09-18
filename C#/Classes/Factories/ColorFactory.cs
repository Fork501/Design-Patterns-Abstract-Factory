using AbstractFactory.Enums;

namespace AbstractFactory.Factories
{
	public abstract class ColorFactory
	{
		public abstract void SetColor(Color color);

		public abstract string GetColorName();
	}
}
