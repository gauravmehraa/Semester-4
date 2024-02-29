import random
def select(arr):
    opps = {}
    while len(arr) > 1:
        for i in range(len(arr)//2):
            if arr[i] > arr[i+1]:
                if opps.get(arr[i]):
                    opps[arr[i]].append(arr[i+1])
                else: 
                    opps[arr[i]] = [arr[i+1]]
                del arr[i+1]
            else:
                if opps.get(arr[i+1]):
                    opps[arr[i+1]].append(arr[i])
                else: 
                    opps[arr[i+1]] = [arr[i]]
                del arr[i]
            i += 1
        print(arr)
    
    winner = arr[0]
    result = float('-inf')
    for opp in opps[winner]:
        result = max(opp, result)
    return result


arr = [5, 10, 2, 19, 13, 11, 18, 6, 4, 17]
print(arr)
print(f"2nd smallest element: {select(arr)}")