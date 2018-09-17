/*
	The Abstract Factory Design Pattern is similar to the Factory Design Pattern.
	The difference is that the factory, itself if abstract, instead of just the resulting objects returned by the factory.
	In this example, we use colors to specify if we want a "light" or "dark" version.
	All that we care about is that we give the factory a Color and then ask it to verify the color that was generated.
	The Colors interface is only implemented by two colors: Blue and Red, but they could have also been
		implemented by DarkBlue and DarkRed in order to exaggerate the resulting factory pattern.
 */

using AbstractFactory.Factories;
using AbstractFactory.Enums;
using System;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			ColorFactory darkFactory = new DarkColorFactory();
			ColorFactory lightFactory = new LightColorFactory();

			#region Blue
			darkFactory.SetColor(Color.Blue);
			Console.WriteLine(darkFactory.GetColorName());

			lightFactory.SetColor(Color.Blue);
			Console.WriteLine(lightFactory.GetColorName());
			#endregion

			#region Red
			darkFactory.SetColor(Color.Red);
			Console.WriteLine(darkFactory.GetColorName());

			lightFactory.SetColor(Color.Red);
			Console.WriteLine(lightFactory.GetColorName());
			#endregion

			Console.ReadLine();
		}
	}
}
