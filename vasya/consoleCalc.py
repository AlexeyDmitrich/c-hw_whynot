# simple calc
'''
Напишите простой калькулятор, который считывает с пользовательского ввода три строки: 
первое число, второе число и операцию, после чего применяет операцию к введённым числам ("первое число" "операция" "второе число") и выводит результат на экран.
Поддерживаемые операции: +, -, /, *, mod, pow, div, где
mod — это взятие остатка от деления,
pow — возведение в степень,
div — целочисленное деление.
'''



def varFst ():
    try:
        a = float(input("Введите первое число:\n"))
        b = float(input("Введите второе число:\n"))
    except:
        print("Введены странные числа")
        varFst()

    operation = str(input("Что будем делать с этими числами?\n"))

    if (operation == "+"):
        return (a + b)
    elif (operation == "-"):
        return (a - b)
    elif (operation == "*"):
        return (a * b)
    elif (operation == "pow"):
        return (a ** b)

    elif (operation == "mod"):
        return (a % b)
    elif (operation == "div"):
        return (a // b)
    elif (operation == "/"):
        return (a / b)
    else:
        print("Неожиданное математическое действие")
        varFst()

#try:
#    result = varFst()
#except (ZeroDivisionError):
#        print("Деление на 0!")
#print(result)

def varSec ():
    expression = input("введите выражение, разделяя числа и знаки пробелами\n \
        например: 1 + 1 \n").split()
#    print(expression)
    legalJob = ["+", "-", "/", "*", "mod", "pow", "div"]
    if (not (expression[1] in legalJob)):
        print("Проверьте правильность ввода: \n \
- стоят ли пробелы между числами и знаком? \n \
- адекватно ли прописаны числа? \n \
- верный ли знак применён?")
        varSec()
        return
    try:
        a = float(expression[0])
        b = float(expression[-1])
        operation = str(expression[1])
    except ValueError: 
        print("Проверьте правильность ввода: \n \
- стоят ли пробелы между числами и знаком? \n \
- адекватно ли прописаны числа? \n \
- верный ли знак применён?")
        varSec()
        return
    result = 0
    if (operation == "+"):
        result = (a + b)
    elif (operation == "-"):
        result = (a - b)
    elif (operation == "*"):
        result = (a * b)
    elif (operation == "pow"):
        result = (a ** b)

    elif (operation == "mod"):
        result = (a % b)
    elif (operation == "div"):
        result = (a // b)
    elif (operation == "/"):
        result = (a / b)
    else:
        print("Неожиданное математическое действие")
    print(a, operation, b, "=", result)
    #return (result)


try:
    varSec()
except ZeroDivisionError:
    print("Делить на 0 в этой программе нельзя")
