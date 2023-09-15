from random import *


def formula(k, l, n, m):
    s = (2*(n+m)*k) + (2*l*k) + (k*(k-1)*m)
    return s

def cycle(k, l, n, m):
    s = 0
    for i in range(k):
        s += 2*l
        s += 2*(n+m)
        s += 2*m*i
    return s


for i in range(10):
    k, l, n, m = [randint(1, 100) for i in range(4)]
    print(formula(k, l, n, m), cycle(k, l, n, m))

