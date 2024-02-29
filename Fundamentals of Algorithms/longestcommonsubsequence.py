

def lcs(string1, string2):
	table = [[0 for i in range(len(string1)+1)] for j in range(len(string2)+1)]
	result = ""

	print(end=' \t')
	for char in string1:
		print(char, end = '\t')
	print()

	for i in range(len(string2)):
		for j in range(len(string1)):
			if string2[i] == string1[j]:
				table[i+1][j+1] = table[i][j] + 1
			else:
				table[i+1][j+1] = max(table[i+1][j], table[i][j+1])

			if j == 0:
				print(string2[i], '\t', table[i+1][j+1], end = '\t')
			else:
				print(table[i+1][j+1], end = '\t')
		print()

	#Backtracking 	
	for i in range(len(string2), 0, -1):
		for j in range(i, 0, -1):
			if table[i][j] == table[i][j-1]:
				continue
			else:
				result += string2[i-1]
				i -= 1
				j -= 1
				break

	print()
	return result[::-1]

print(lcs("LONGEST", "STONE"))
# print(lcs("execution", "intention"))