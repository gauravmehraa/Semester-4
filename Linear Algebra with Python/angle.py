import math
def userinput(rows):
	arr = [0 for i in range(rows)]
	for i in range(rows):
		arr[i] = int(input("Enter no. "))
	print()
	return arr

def dotproduct(arr1, arr2):
	result = 0
	for i in range(len(arr1)):
		result += (arr1[i]*arr2[i])
	return result

def magnitude(arr):
	s = 0
	for n in arr:
		s += (n**2)
	return math.sqrt(s)

def angle(arr1, arr2):
	result = 0
	for i in range(len(arr1)):
		result += (arr1[i] - arr2[i])**2
	return math.degrees(math.acos(dotproduct(arr1, arr2)/(magnitude(arr1) * magnitude(arr2))))

r = int(input("Enter no. of rows: "))
arr1 = userinput(r)
arr2 = userinput(r)
print(f"Angle = {angle(arr1, arr2)}")