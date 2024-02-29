class Node:
	def __init__(self, value, left=None, right=None):
		self.value = value	
		self.left = left
		self.right = right

class BST:
	def __init__(self, value):
		self.root = Node(value)

	def insert(self, root, newnode):
		if root.value > newnode.value:
			if root.left is None:
				root.left = newnode
				newnode.parent = root
			else:
				self.insert(root.left, newnode)
		else:
			if root.right is None:
				root.right = newnode
				newnode.parent = root
			else:
				self.insert(root.right, newnode)
	
	def delete(self, root, value):
		if root is None:
			return root

		if value < root.value:
			root.left = self.delete(root.left, value)
			return root
		elif value > root.value:
			root.right = self.delete(root.right, value)
			return root

		if root.left is None: # If no left child
			temp = root.right
			del root
			return temp
		elif root.right is None: # If no right child
			temp = root.left
			del root
			return temp
		else: # If both children
			replacementparent = root
			replacement = root.right
			while replacement.left is not None:
				replacementparent = replacement
				replacement = replacement.left
			
			if replacementparent is not root:
				replacementparent.left = replacement.right
			else:
				replacementparent.right = replacement.right
			
			root.value = replacement.value
			del replacement
			return root

	def inorder(self, root):
		if root:
			self.inorder(root.left)
			print(root.value, end= ' ')			
			self.inorder(root.right)

b = BST(5)
b.insert(b.root, Node(8))
b.insert(b.root, Node(10))
b.insert(b.root, Node(3))
b.insert(b.root, Node(1))
b.insert(b.root, Node(6))
b.insert(b.root, Node(4))
b.insert(b.root, Node(7))
b.insert(b.root, Node(9))
b.insert(b.root, Node(12))

print("Before deletion")
b.inorder(b.root)
b.delete(b.root, 9)
print("\nAfter deletion")
b.inorder(b.root)

