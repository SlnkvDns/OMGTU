#Тесты с файла
def f():
    for l in range(1, 9):
        f = open(f"D:\Работы\Олимпиады\Интенсификация производства\input_s1_{l:02}.txt")
        d1, m1, y1 = map(int, f.readline().split('.'))
        d2, m2, y2 = map(int, f.readline().split('.'))
        p = int(f.readline())

        dct = {1: 31, 2: 28, 3: 31, 4: 30, 5:31, 6: 30, 7: 31, 8: 31, 9: 30, 10:31, 11:30, 12: 31}
        if y1 % 4 == 0:
            dct[2] = 29
        if y1 != y2:
            count_days = 0
            if m1 != 12:
                count_days += dct[m1] - d1 + 1
                for i in range(m1+1, 13):
                    count_days += dct[i]
            else:
                count_days += dct[12] - d1 + 1

            for i in range(y1+1, y2):
                if i % 4 == 0:
                    count_days += 366
                else:
                    count_days += 365


            if y2 % 4 == 0:
                dct[2] = 29
            else:
                dct[2] = 28

            for i in range(1, m2):
                count_days += dct[i]
            count_days += d2
        elif y1 == y2 and m1 == m2:
            count_days = d2 - d1 + 1
        else:
            count_days = dct[m1] - d1 + 1
            for i in range(m1+1, m2):
                count_days += dct[i]
            count_days += d2
        an = p + (count_days - 1) * 1

        f = open(f"D:\Работы\Олимпиады\Интенсификация производства\output_s1_{l:02}.txt")
        print(f"Правильный ответ: {f.readline()}")
        print(f"Мой ответ:        {int(((p + an) / 2) * count_days)}")
        print("---------------------------------------------------")

#Ввод с клавиатуры
def g():
    d1, m1, y1 = map(int, input().split('.'))
    d2, m2, y2 = map(int, input().split('.'))
    p = int(input())

    dct = {1: 31, 2: 28, 3: 31, 4: 30, 5:31, 6: 30, 7: 31, 8: 31, 9: 30, 10:31, 11:30, 12: 31}
    if y1 % 4 == 0:
        dct[2] = 29
    if y1 != y2:
        count_days = 0
        if m1 != 12:
            count_days += dct[m1] - d1 + 1
            for i in range(m1+1, 13):
                count_days += dct[i]
        else:
            count_days += dct[12] - d1 + 1

        for i in range(y1+1, y2):
            if i % 4 == 0:
                count_days += 366
            else:
                count_days += 365


        if y2 % 4 == 0:
            dct[2] = 29
        else:
            dct[2] = 28

        for i in range(1, m2):
            count_days += dct[i]
        count_days += d2
    elif y1 == y2 and m1 == m2:
        count_days = d2 - d1 + 1
    else:
        count_days = dct[m1] - d1 + 1
        for i in range(m1+1, m2):
            count_days += dct[i]
        count_days += d2
    an = p + (count_days - 1) * 1

    print(int(((p + an) / 2) * count_days))
g()
