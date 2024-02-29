import math

def eigenvector(vector, value):
	for i in range(len(vector)):
		for j in range(len(vector[0])):
			if i == j: vector[i][j] -= value
	return vector

def findRoots(a, b, c):
	d = (b*b) - (4*a*c)
	s1 = (-b - math.sqrt(d)) / (a + a)
	s2 = (-b + math.sqrt(d)) / (a + a)
	return [-s1, -s2]

def eigenvalue(vector):
	a = 1
	b = vector[0][0] + vector[1][1]
	c = vector[0][0] * vector[1][1] - vector[0][1] * vector[1][0]

	roots = findRoots(a, b, c)
	print(f"Roots: {roots}")

	for root in roots:
		print(f"Eigenvector for {root}: {eigenvector(vector, root)}")

m = [[4, 2], [1, 3]]
eigenvalue(m)