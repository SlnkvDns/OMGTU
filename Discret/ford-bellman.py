inf = float("+inf")

graf = [[inf, 7, inf, inf, 9, 2, inf, inf, inf, inf, inf, inf],
        [7, inf, 5, 4, 8, 2, inf, inf, inf, inf, inf, inf],
        [inf, 5, inf, 2, 9, inf, inf, inf, inf, inf, inf, inf],
        [inf, 4, 2, inf, 3, inf, 8, 3, inf, inf, inf, inf],
        [9, 8, 9, 3, inf, 3, 5, 1, 7, inf, inf, inf],
        [2, 2, inf, inf, 3, inf, inf, 6, 1, inf, inf, inf],
        [inf, inf, inf, 8, 5, inf, inf, 6, inf, 4, 4, inf],
        [inf, inf, inf, 3, 1, 6, 6, inf, 2, 7, 8, 5],
        [inf, inf, inf, inf, 7, 1, inf, 2, inf, inf, 6, 1],
        [inf, inf, inf, inf, inf, inf, 4, 7, inf, inf, 10, inf],
        [inf, inf, inf, inf, inf, inf, 4, 8, 6, 10, inf, 3],
        [inf, inf, inf, inf, inf, inf, inf, 5, 1, inf, 3, inf]]

n = len(graf)
a = int(input("Начальная вершина: "))

l = [[inf] * n for i in range(n)]
for i in range(n):
    for j in range(n):
        l[a-1][i] = 0

for k in range(1, n):
    for i in range(0, n):
        if i == a - 1:
            continue
        mn = inf
        for j in range(n):
            if graf[j][i] != inf and l[j][k-1] + graf[j][i] < mn:
                mn = l[j][k-1] + graf[j][i]
        l[i][k] = mn

answer = []
for i in range(n):
    answer.append(l[i][-1])
print(answer)
