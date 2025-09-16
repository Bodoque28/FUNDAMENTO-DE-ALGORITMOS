edad = int (input("INGRESE SU EDAD: "))
if edad >=18 :
    print("Es elegible para votar")
    if edad >= 25 :
        print("Es posible candidato")
    else:
        print ("No puede ser candidato")
        
else:
    print("No es elible para votar")
