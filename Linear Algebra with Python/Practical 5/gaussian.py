
def gaussianElimination(m):
    rows = len(m)
    cols = len(m[0])
    for i in range(rows):
        if m[i][i] == 0.0:
            return "Invalid"
        for j in range(rows):
            if i != j:
                factor = m[j][i] /m[i][i]
                for k in range(cols):
                    m[j][k] = m[j][k] - factor * m[i][k]
    for i in range(rows):
        factor = m[i][i]
        for j in range(cols):
            m[i][j] = round(m[i][j] / factor)
    return [row[-1] for row in m]
    


m = [[3.0, 2.0, -4.0, 3.0], [2.0, 3.0, 3.0, 15.0], [5.0, -3, 1.0, 14.0]]
print(gaussianElimination(m))