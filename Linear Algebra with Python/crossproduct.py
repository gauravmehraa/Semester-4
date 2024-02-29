
def userinput(rows):
	arr = [0 for i in range(rows)]
	for i in range(rows):
		arr[i] = int(input("Enter no. "))
	print()
	return arr

def determinant(m):
	return [minor(m, 0, 0), minor(m, 0, 1), minor(m, 0, 2)]

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


def crossproduct(arr1, arr2):
	result = [[1, 1, 1]]
	result.append(arr1)
	result.append(arr2)
	return determinant(result)

r = int(input("Enter no. of rows: "))
arr1 = userinput(r)
arr2 = userinput(r)
prod = crossproduct(arr1, arr2)
print(f"Cross Product = {prod[0]}i {prod[1]}j {prod[2]}k")