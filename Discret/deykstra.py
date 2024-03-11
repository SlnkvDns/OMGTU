inf = float("inf")
graf = [[-1, 7, -1, -1, 9, 2, -1, -1, -1, -1, -1, -1],
        [7, -1, 5, 4, 8, 2, -1, -1, -1, -1, -1, -1],
        [-1, 5, -1, 2, 9, -1, -1, -1, -1, -1, -1, -1],
        [-1, 4, 2, -1, 3, -1, 8, 3, -1, -1, -1, -1],
        [9, 8, 9, 3, -1, 3, 5, 1, 7, -1, -1, -1],
        [2, 2, -1, -1, 3, -1, -1, 6, 1, -1, -1, -1],
        [-1, -1, -1, 8, 5, -1, -1, 6, -1, 4, 4, -1],
        [-1, -1, -1, 3, 1, 6, 6, -1, 2, 7, 8, 5],
        [-1, -1, -1, -1, 7, 1, -1, 2, -1, -1, 6, 1],
        [-1, -1, -1, -1, -1, -1, 4, 7, -1, -1, 10, -1],
        [-1, -1, -1, -1, -1, -1, 4, 8, 6, 10, -1, 3],
        [-1, -1, -1, -1, -1, -1, -1, 5, 1, -1, 3, -1]]

distances = [inf] * 12
a = int(input("Начальная вершина: "))
b = int(input("Конечная вершина: "))
distances[a-1] = 0
marked = set()

while (b-1) not in marked:
    mn = inf
    for i in range(12):
        if i not in marked and distances[i] < mn:
            mn = distances[i]
            u = i
    for i in range(12):
        if graf[u][i] != -1 and i not in marked:
            distances[i] = min(distances[i], distances[u] + graf[u][i])
        marked.add(u)
print(distances[b-1])
