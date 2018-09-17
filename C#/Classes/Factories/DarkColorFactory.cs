using AbstractFactory.Colors;
using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Factories
{
	public class DarkColorFactory : ColorFactory
	{
		private IColor _color;

		public override string GetColorName()
		{
			return $"Dark { _color.Name }";
		}

		public override void SetColor(Color color)
		{
			switch (color)
			{
				case Color.Blue:
					_color = new BlueColor();
					break;
				case Color.Red:
					_color = new RedColor();
					break;
				default:
					throw new NotImplementedException("Color");
			}
		}
	}
}
