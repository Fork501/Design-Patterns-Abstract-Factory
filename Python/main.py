from Color import Color
from ColorFactories import DarkColorFactory, LightColorFactory


def main():
	dark_factory = DarkColorFactory()
	light_factory = LightColorFactory()

	# BEGIN Blue
	dark_factory.set_color(Color.BLUE)
	print dark_factory.get_color_name()

	light_factory.set_color(Color.BLUE)
	print light_factory.get_color_name()
	# END Blue

	# BEGIN Red
	dark_factory.set_color(Color.RED)
	print dark_factory.get_color_name()

	light_factory.set_color(Color.RED)
	print light_factory.get_color_name()
	# END Red


if __name__ == '__main__':
	main()
