def quicksort(l):
	if len(l) <= 1:
		return l
	pivot = l[len(l) // 2]
	left = [n for n in l if n < pivot]
	middle = [n for n in l if n == pivot]
	right = [n for n in l if n > pivot]
	return quicksort(left) + middle + quicksort(right)

print(quicksort([4, 6, 1, 0, 10, -3, 0]))