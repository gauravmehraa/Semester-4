
def userinput():
	matrix = [[0 for i in range(3)] for j in range(3)]
	for i in range(3):
		for j in range(3):
			matrix[i][j] = int(input("Enter no: "))
	return matrix

def determinant(m):
	return (m[0][0]*minor(m, 0, 0)) - (m[0][1]*minor(m, 0, 1)) + (m[0][2]*minor(m, 0, 2))

def minor(m, row, col):
	temp = []
	for i in range(3):
		if i == row:
			continue
		for j in range(3):
			if j == col:
				continue
			temp.append(m[i][j])
	return ((temp[0] * temp[3]) - (temp[1] * temp[2]))

def cofactor(m):
	matrix = [[0 for i in range(3)] for j in range(3)]
	for i in range(3):
		for j in range(3):
			matrix[i][j] = ((-1)**(i+j))*minor(m, i, j)
	return matrix

def transpose(m):
	matrix = [[0 for i in range(3)] for j in range(3)]
	for i in range(3):
		for j in range(3):
			matrix[i][j] = m[j][i]
	return matrix

def inverse(m):
	det = determinant(m)
	if not det:
		print("No inverse")
		return
	adj = transpose(cofactor(m))
	print("Inverse: ")
	for i in range(3):
		for j in range(3):
			adj[i][j] = f"({adj[i][j]}/{det})"
			print(adj[i][j], end = '')
		print()

m1 = userinput()
inverse(m1)