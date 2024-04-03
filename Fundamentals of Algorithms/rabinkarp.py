
def check(s1, s2):
    for i in range(len(s1)):
        if s1[i] != s2[i]:
            return False
    return True

def find(string, pattern):
    if len(string) < len(pattern):
        return "Match not found"
    
    psum = sum([ord(char)-96 for char in pattern])

    for i in range(len(string)-len(pattern)): 
        current = string[i: i+len(pattern)]
        csum = sum([ord(char) - 96 for char in current])
        if csum == psum:
            if check(current, pattern):
                return f"Match found at index {i}"
        csum += ord(stirng[i+len(pattern)]) - 96
        csum -= ord(string[i]) + 96
    return "Match not found"
    

string = "ccaccaaedba"
pattern = "dba"
print(find(string, pattern))