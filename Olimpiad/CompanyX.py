from sys import setrecursionlimit
from functools import lru_cache
setrecursionlimit(20000)

for k in range(1, 17):
    sotrudniki = {}
    sotrudniki2 = {}
    with open(f"D:\\comp\\input_s1_{k:02}.txt") as f, open(f"D:\\comp\\output_s1_{k:02}.txt") as f2:
        s1 = f.readline().split()
        if s1[0] not in sotrudniki2.keys():
            if len(s1) == 1:
                sotrudniki2[s1[0]] = "Unknown Name"
            else:
                sotrudniki2[s1[0]] = " ".join(s1[1:])
        else:
            if sotrudniki2[s1[0]] == "Unknown Name" and len(s1) != 1:
                sotrudniki2[s1[0]] = " ".join(s1[1:])
        if len(s1) != 1:
            s1 = s1[0:1]
        s2 = f.readline().split()
        if s2[0] not in sotrudniki2.keys():
            if len(s2) == 1:
                sotrudniki2[s2[0]] = "Unknown Name"
            else:
                sotrudniki2[s2[0]] = " ".join(s2[1:])
        else:
            if sotrudniki2[s2[0]] == "Unknown Name" and len(s2) != 1:
                sotrudniki2[s2[0]] = " ".join(s2[1:])
        if len(s2) != 1:
            s2 = s2[0:1]
        sotrudniki[" ".join(s1)] = [" ".join(s2)]

        while True:
            s1 = f.readline().split()
            if s1[0] == "END":
                break
            if s1[0] not in sotrudniki2.keys():
                if len(s1) == 1:
                    sotrudniki2[s1[0]] = "Unknown Name"
                else:
                    sotrudniki2[s1[0]] = " ".join(s1[1:])
            else:
                if sotrudniki2[s1[0]] == "Unknown Name" and len(s1) != 1:
                    sotrudniki2[s1[0]] = " ".join(s1[1:])
            if len(s1) != 1:
                s1 = s1[0:1]

            s2 = f.readline().split()
            if s2[0] not in sotrudniki2.keys():
                if len(s2) == 1:
                    sotrudniki2[s2[0]] = "Unknown Name"
                else:
                    sotrudniki2[s2[0]] = " ".join(s2[1:])
            else:
                if sotrudniki2[s2[0]] == "Unknown Name" and len(s2) != 1:
                    sotrudniki2[s2[0]] = " ".join(s2[1:])

            if len(s2) != 1:
                s2 = s2[0:1]

            if " ".join(s1) not in sotrudniki.keys():
                sotrudniki[" ".join(s1)] = [" ".join(s2)]
            else:
                sotrudniki[" ".join(s1)].append(" ".join(s2))

        lst = set()
        @lru_cache(None)
        def find(name):
            global lst
            if name not in sotrudniki.keys():
                lst.add(name)
                return
            for i in sotrudniki[name]:
                lst.add(i)
                find(i)


        name = f.readline()
        if any(x not in "0123456789" for x in name):
            for i, j in sotrudniki2.items():
                if j == name:
                    name = i
        find(name)

        lst1 = list(lst)
        lst1.sort()
        if name in lst1:
            lst1.remove(name)
        lst1 = list(map(lambda x: x + " " + sotrudniki2[x], lst1))
        if len(lst1) == 0:
            lst1.append('NO')
        flag = True
        test = f2.readlines()
        for l in range(len(test)):
            test[l] = test[l].replace("\n", "")
        for i in range(len(test)):
            if lst1[i] != test[i]:
                flag = False
                break
        print(f"Test{k}: {flag}")




