# тесты c файлов
def milk_test():
    for j in range(1, 11):
        # файл с тестами (input)
        f = open(f'D:\Работы\Олимпиады\Упаковки молока\input{j}.txt')
        n = int(f.readline())
        minM= float('+inf')
        for i in range(n):
            x1, y1, z1, x2, y2, z2, c1, c2 = map(float, f.readline().split())
            v1 = (x1 * y1 * z1) / 1000
            v2 = (x2 * y2 * z2) / 1000
            s1 = 2*(x1*y1 + x1*z1 + y1*z1) 
            s2 = 2*(x2*y2 + x2*z2 + y2*z2) 
            m = (s1*c2 - s2*c1)/(v2*s1 - v1*s2)
            if m < minM:
                minM = m
                a = i+1
        # файл с тестами (output)
        f2 = open(f'D:\Работы\Олимпиады\Упаковки молока\output{j}.txt')
        print(f"Test{j}")
        print(f"Мой    результат: {a} {round(minM, 2)}")
        print(f"Правильный ответ: {f2.readline()}\n")
    
#ввод с клавиатуры
def milk_keyboard():
    n = int(input())
    minM= float('+inf')
    for i in range(n):
        x1, y1, z1, x2, y2, z2, c1, c2 = map(float, input().split())
        v1 = (x1 * y1 * z1) / 1000
        v2 = (x2 * y2 * z2) / 1000
        s1 = 2*(x1*y1 + x1*z1 + y1*z1) 
        s2 = 2*(x2*y2 + x2*z2 + y2*z2) 
        m = (s1*c2 - s2*c1)/(v2*s1 - v1*s2)
        if m < minM:
            minM = m
            a = i+1
    print(f"{a} {round(minM, 2)}")
milk_test()
milk_keyboard()
