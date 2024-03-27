class Node:
	def __init__(self, left=None, right=None):
		self.left = left
		self.right = right

	def children(self):
		return(self.left, self.right)


def huffmanTree(node, isLeft=True, binary=''):
	if type(node) is str:
		return {node: binary}
	(l, r) = node.children()
	d = {}
	d.update(huffmanTree(l, True, binary + '0'))
	d.update(huffmanTree(r, False, binary + '1'))
	return d

def huffmanEncode(string):
	frequency = {}
	for char in string:
		if char not in frequency:
			frequency[char] = 0
		frequency[char] += 1

	frequency = sorted(frequency.items(), key=lambda x: x[1], reverse=True)
	nodes = frequency

	while len(nodes) > 1:
		(key1, c1), (key2, c2) = nodes[-1], nodes[-2]
		nodes = nodes[:-2]
		node = Node(key1, key2)
		nodes.append((node, c1 + c2))
		nodes = sorted(nodes, key=lambda x: x[1], reverse=True)

	huffmanCode = huffmanTree(nodes[0][0])
	print('Char\tCode')
	for (c, f) in frequency:
		print(c, '\t', huffmanCode[c])

huffmanEncode("aaaaaaaaaaabbbbbbbbbbbbcccccccccccccddddddddddddddeeeeeeeeeeeeeeeeeeeeeeeffffffffffffffffffffffffff")