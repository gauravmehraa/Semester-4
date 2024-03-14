
def userinput():
	rows = int(input("Enter no. of rows: "))
	matrix = [0 for i in range(rows)]
	for i in range(rows):
		matrix[i] = int(input("Enter no.: "))
	print()
	return matrix

def add(m1, m2):
	return [m1[i] + m2[i] for i in range(len(m1))]

m1 = userinput()
m2 = userinput()
m3 = add(m1, m2)
print(m3)