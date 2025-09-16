print("1.efectivo ")
print("2 tarjeta ")
print("3 transferencia ")
n_m_pago=int(input("Digite # de metodo de pago: "))
t_pagar=float(input("digite total a pagar: "))
incremento=0
des=0
if (n_m_pago==1):
    des=0.07*t_pagar
elif (n_m_pago==2):
    print ("1 debito ")
    print ("2 credito")
    n_t_tarjeta=int(input("Digite # de tipo de tarjeta: "))
    cant=int(input("digite cantidad: "))
    if(n_t_tarjeta==1):
        if(cant>10):
             des=0.05*t_pagar
    else:
        incremento=0.05*t_pagar
else:
    if (t_pagar==100):
        des=10
m_pagar=t_pagar+incremento-des
print("TOTAL: $",t_pagar)
if(des!=0):
    print ("DESCUENTO: $",round(des,2))
else:
    print("Incremento: $",incremento)
print ("TOTAL: $",m_pagar)
