# Abstract Factory Design Pattern
It would be helpful to familiarize yourself with the Factory Design Pattern before tackling this project.

Much like the Factory Design Pattern, the Abstract Factory Design Pattern is a way of obtaining objects, without the need for defining them as a concrete class.  It allows for flexibility in making changes.

The difference is that the factory, itself if abstract, instead of just the resulting objects returned by the factory.

In this project's example, we're using colors to define if we would like to generate "Light" or "Dark" versions.  We don't care how the colors are generated and we don't care to receive a copy of them.  Instead, we're going to allow our factory to generate the color and hold the information, for when we need it later.

You will see how the factory inherits from a base, abstract class and implements a way to interrogate it for the current color.

_Please feel free to make changes that correct errors_