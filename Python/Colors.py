from abc import abstractproperty


# Naming convention to keep with C# example, but this isn't an actual interface
class IColor:

	def __init__(self):
		pass

	@abstractproperty
	def name(self):
		pass


class BlueColor(IColor):

	@property
	def name(self):
		return 'Blue'


class RedColor(IColor):

	@property
	def name(self):
		return 'Red'
