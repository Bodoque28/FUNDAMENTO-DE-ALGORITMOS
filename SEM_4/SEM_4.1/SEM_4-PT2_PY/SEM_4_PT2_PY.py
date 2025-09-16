
def ejer1():
    nombre= input ("NOMBRE: ")
    carrera = input("CARRERA: ")
    print (f"\n {nombre}  bienvenido a mundo UPN en su carrera de  { carrera}  :v py")

def ejer2():
    print("\"EDUARDO :V\"")
def ejer3():
    num1=int (input("Primer Numero: "))
    num2=int (input("Segundo Numero: "))
    print("SUMA: ",num1+num2)
    print("RESTA: ",num1-num2)
    print("MULTIPLICACION: ",num1*num2)
    print("DIVISION: ",num1/num2)
import math #libreria para calculos
def ejer4():
    num=float(input("INGRESE NUMERO DECIMAL: "))
    raiz=math.sqrt(num)
    redo=round(num,2)
    cubo=math.pow(num,3)
    cubica=num**1/3
    print("Raiz cuadrada: ", raiz)
    print("Redondeado: " + redo)
    print("Elevado a 3: " + cubo)
    print("Raiz cubica: " + cubica)
def ejer5():
    num=input("Ingrese un numero: ")
    entero=int(num)
    deci= float(num)
    print("Resto: ",(entero%2))
    print("Decimal: ",(deci/3))
        
ejer5()