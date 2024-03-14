  

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
	try:
		copy = [[0 for j in range(len(m))] for i in range(len(m[0]))]
	except TypeError:
		return [[n] for n in m]

	for i in range(len(m[0])):
		for j in range(len(m)):
			copy[i][j] = m[j][i]
	return copy

def inverse(m):
	det = determinant(m)
	adj = transpose(cofactor(m))
	for i in range(3):
		for j in range(3):
			adj[i][j] = adj[i][j]/det
	return adj

def multiply(arr1, arr2):
	result = [[sum(a*b for a, b in zip(arow, bcol)) for bcol in zip(*arr2)] for arow in arr1]

	return result

def changebasis(vector, oldbasis, newbasis):
	adj1 = transpose(oldbasis)
	adj2 = transpose(newbasis)
	inv1 = inverse(adj1)
	result = multiply(multiply(inv1, adj2), transpose(vector))
	return result

m1 = [[1, 0, 0],
		[0, 1, 0],
		[0, 0, 1]]
m2 = [[1, 3, 4],
		[2, -1, 1],
		[1, 0, 2]]
vector = [2, 3, -1]
print(changebasis(vector, m1, m2))