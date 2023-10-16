maxN = int(input())
count = maxN
for i in range(2, 10**10000):
    if 2**i - 1 > maxN:
        break
    count += int(maxN/(2**i - 1))
print(count)
