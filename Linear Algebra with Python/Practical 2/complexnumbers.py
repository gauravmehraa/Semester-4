class Complex:
	def __init__(self, real, img):
		self.real = real
		self.img = img

	def add(self, c2):
		return Complex(self.real + c2.real, self.img + c2.img)

	def subtract(self, c2):
		return Complex(self.real - c2.real, self.img - c2.img)

	def multiply(self, c2):
		real = (self.real * c2.real) - (self.img * c2.img)
		img = (self.img * c2.real) + (self.real * c2.img)
		return Complex(real, img)

	def display(c):
		if c.img > 0:
			return f"{c.real} + {c.img}i"
		else:
			return f"{c.real} - {abs(c.img)}i"

a = Complex(3, 4)
b = Complex(-4, 5)
print(f"a = {a.display()}")
print(f"b = {b.display()}")

print(f"Addition = {a.add(b).display()}")
print(f"Subtraction = {a.subtract(b).display()}")
print(f"Multiplication = {a.multiply(b).display()}")