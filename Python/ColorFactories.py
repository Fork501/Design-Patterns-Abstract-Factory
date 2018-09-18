from abc import abstractmethod
from Color import Color
from Colors import BlueColor, RedColor


class ColorFactory:

	def __init__(self):
		pass

	@abstractmethod
	def get_color_name(self):
		pass

	@abstractmethod
	def set_color(self, color):
		pass


class DarkColorFactory:

	def __init__(self):
		self.color = None

	def get_color_name(self):
		return 'Dark {0}'.format(self.color.name)

	def set_color(self, color):
		if color == Color.BLUE:
			self.color = BlueColor()
		elif color == Color.RED:
			self.color = RedColor()


class LightColorFactory:

	def __init__(self):
		self.color = None

	def get_color_name(self):
		return 'Light {0}'.format(self.color.name)

	def set_color(self, color):
		if color == Color.BLUE:
			self.color = BlueColor()
		elif color == Color.RED:
			self.color = RedColor()
