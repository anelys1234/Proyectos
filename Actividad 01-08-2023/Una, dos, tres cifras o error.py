NUMERO = int(input('Ingresar un numero entero: '))
if NUMERO < 10:
    print('El numero ingresado es de una cifras')
else:
    if NUMERO < 100:
        print('El numero ingresado es de dos cifras')
    else:
        if NUMERO < 1000:
            print('El numero ingresado es de tres cifra.')
        else:
            print('ERROR, el numero ingresado tiene mas de tres cifras')
