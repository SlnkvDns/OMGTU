#Ввод с клавиатуры
def f():
    x, y, l, c1, c2, c3, c4, c5, c6 = map(int, input().split())
    cost = 0
    if l > 2*x + 2*y:
        cost += (c2+c6)*(l-(2*x+2*y))
        l = 2*x + 2*y
    if y <= l:
        cost += min(c1*y, (c2+c6+c5+c4)*y, (c2+c3)*y)
        cost += min((c2+c3)*(l-y), (c2+c4+c5+c6)*(l-y))
        cost += (c4+c5)*(2*x+2*y-l)
    if y > l:
        cost += min(c1*l, (c2+c6+c5+c4)*l, (c2+c3)*l)
        cost += (c4+c5)*(2*x+2*y-l)
    print(cost)

#Тесты с файлов
def g():
    for i in range(1, 15):
        f = open(f'D:\Работы\Олимпиады\Постройка дома\input_s1_{i:02}.txt')
        x, y, l, c1, c2, c3, c4, c5, c6 = map(int, f.readline().split())
        cost = 0
        if l > 2*x + 2*y:
            cost += (c2+c6)*(l-(2*x+2*y))
            l = 2*x + 2*y
        if y <= l:
            cost += min(c1*y, (c2+c6+c5+c4)*y, (c2+c3)*y)
            cost += min((c2+c3)*(l-y), (c2+c4+c5+c6)*(l-y))
            cost += (c4+c5)*(2*x+2*y-l)
        if y > l:
            cost += min(c1*l, (c2+c6+c5+c4)*l, (c2+c3)*l)
            cost += (c4+c5)*(2*x+2*y-l)

        f2 = open(f'D:\Работы\Олимпиады\Постройка дома\output_s1_{i:02}.txt')
        print(f"Мой ответ: {cost}")
        print(f"Правильный ответ: {f2.readline()}")
        print()
f()
