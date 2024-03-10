def mix(mas):
    string = "MX" + "".join(mas) + "XM"
    for i in "0123456789":
        string = string.replace(i, "")
    return string


def water(mas):
    string = "WT" + "".join(mas) + "TW"
    for i in "0123456789":
        string = string.replace(i, "")
    return string


def dust(mas):
    string = "DT" + "".join(mas) + "TD"
    for i in "0123456789":
        string = string.replace(i, "")
    return string


def fire(mas):
    string = "FR" + "".join(mas) + "RF"
    for i in "0123456789":
        string = string.replace(i, "")
    return string

for i in range(1, 11):
    f1 = open(f'C:\\Users\\Denis\\Downloads\\Зельеварение\\input{i}.txt')
    f2 = open(f'C:\\Users\\Denis\\Downloads\\Зельеварение\\output{i}.txt')
    zakl = [""]
    while True:
        string = f1.readline().split()
        m = []
        if len(string) == 0:
            break

        s = ""
        for i in string:
            if all(x in "0123456789" for x in i):
                s += zakl[int(i)]
            if i != "MIX" and i != "DUST" and i != "WATER" and i != "FIRE":
                s += i
        if string[0] == "MIX":
            zakl.append(mix(s))
        elif string[0] == "WATER":
            zakl.append(water(s))
        elif string[0] == "DUST":
            zakl.append(dust(s))
        elif string[0] == "FIRE":
            zakl.append(fire(s))

    test = f2.readline()
    test = test.replace("\n", "")
    if zakl[-1] == test:
        print("OK")
    else:
        print("FAIL")
