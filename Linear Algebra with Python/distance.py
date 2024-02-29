import math
def userinput(rows):
	arr = [0 for i in range(rows)]
	for i in range(rows):
		arr[i] = int(input("Enter no. "))
	print()
	return arr

def distance(arr1, arr2):
	result = 0
	for i in range(len(arr1)):
		result += (arr1[i] - arr2[i])**2
	return math.sqrt(result)

r = int(input("Enter no. of rows: "))
arr1 = userinput(r)
arr2 = userinput(r)
print(f"Distance = {distance(arr1, arr2)}")