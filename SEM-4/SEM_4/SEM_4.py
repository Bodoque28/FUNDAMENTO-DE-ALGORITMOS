años=float (input ("AÑOS DE TRABAJO: "))
venta=float(input("VENTA TOTALES: "))
hijos=float(input("NUMERO DE HIJOS: "))
boni="no"      
if (años >= 3)or(venta>= 3500)or (hijos != 0): boni = "SI"
print(f" Usted {boni} recibe bonificacion ")
        
