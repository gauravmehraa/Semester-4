def userinput(rows, cols):
	arr = [[0 for i in range(rows)] for j in range(cols)]
	for i in range(rows):
		for j in range(cols):
			arr[i][j] = int(input("Enter no. "))
	print()
	return arr

def multiply(arr1, arr2):

	result = [[0 for i in range(len(arr1))] for j in range(len(arr2))]

	for i in range(len(arr1)):
		for j in range(len(arr2[0])):
			for k in range(len(arr2)):
				result[i][j] += arr1[i][k] * arr2[k][j]
	return result

r = int(input("Enter no. of rows: "))
c = int(input("Enter no. of cols: "))
arr1 = userinput(r, c)
arr2 = userinput(r, c)
prod = multiply(arr1, arr2)
print(prod)