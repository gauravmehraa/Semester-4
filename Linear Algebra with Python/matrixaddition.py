
def userinput():
	rows = int(input("Enter no. of rows: "))
	cols = int(input("Enter no. of cols: "))
	matrix = [[None]*cols]*rows

	for i in range(rows):
		for j in range(cols):
			matrix[i][j] = int(input("Enter no.: "))
	print()
	return matrix

def add(m1, m2):
	matrix = [[None]*len(m1[0])]*len(m1)
	for i in range(rows):
		for j in range(cols):
			matrix[i][j] = m1[i][j] + m2[i][j]
	return matrix

m1 = userinput()
m2 = userinput()
m3 = add(m1, m2)
print(m3)