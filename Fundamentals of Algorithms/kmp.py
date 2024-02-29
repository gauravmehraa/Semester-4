
def kmp(string, pattern, lps):
	if len(string) < len(pattern):
		return "Invalid"

	i, j = 0, -1
	while i < len(string):
		if string[i] == pattern[j+1]:
			i += 1
			j += 1
		else:
			j = lps[j]
			if string[i] != pattern[j+1]:
				i += 1
		if j == len(pattern)-1:
			return f"Found at index: {i-j-1}"
		if i == len(string):
			return "Not found"

def findLPS(pattern):
	chars = set()
	lps = []
	for char in pattern:
		if char in chars:
			lps.append(lps[-1]+1)
		else:
			lps.append(0)
		chars.add(char)
	return lps

string = "abc abcdab abcdabcdabde"
pattern = "abcdabd"
lps = findLPS(pattern)
print(kmp(string, pattern, lps))