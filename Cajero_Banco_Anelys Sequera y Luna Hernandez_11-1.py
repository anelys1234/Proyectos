print("Bienvenido al menu de opciones de banco.")

def menu_bancos():
    print("Elija un banco: ")
    print("1. Banco de Bogotá")
    print("2. AV Villas")
    print("3. Bancolombia")
    print("4. Otro banco")

menu_bancos()

OPCIONES = int(input("Seleccione el banco de su preferencia: "))

if OPCIONES == 1:
    print("Haz elegido el Banco de Bogotá")
elif OPCIONES == 2:
    print("Haz elegido el AV Villas")
elif OPCIONES == 3:
    print("Haz elegido Bancolombia")
elif OPCIONES == 4:
    print("Haz elegido la opción de otros bancos")
    BANCO = input("Por favor, ingrese el nombre del banco: ")
    print("Su banco es: " + BANCO)

INTENTOS = 3
for i in range(INTENTOS):
    CONTRASEÑA = int(input("Digite la contraseña: "))
    if CONTRASEÑA == 1234:
        def menu_opciones_bancarias():
            print("Opciones de transacción:")
            print("1. Consultar Saldo")
            print("2. Depositar Saldo")
            print("3. Retirar saldo")
            print("4. Salir")

        menu_opciones_bancarias()
        OPB = int(input('Seleccione su transacción: '))

        SALDO = 1300000 

        if OPB == 1:
            print("Su saldo actual es: $", SALDO)
            print("Ha completado su transacción. Se ha cerrado la sesión. Vuelva pronto")
        elif OPB == 2:
            DPS = int(input("Digite la cantidad a depositar: "))
            SALDO += DPS
            print("El saldo actual es: $", SALDO)
            print("Ha completado su transacción. Se ha cerrado la sesión. Vuelva pronto")
        elif OPB == 3:
            RETIRO = int(input("Digite la cantidad a retirar: "))
            if RETIRO <= SALDO:
                SALDO -= RETIRO
                print("El saldo actual es: $", SALDO)
                print("Ha completado su transacción. Se ha cerrado la sesión. Vuelva pronto")
            else:
                print("El Saldo es insuficiente")
                print("Se ha cerrado sesión. Vuelva pronto.")
        elif OPB == 4:
            print("Su sesión ha sido cerrada. Vuelva pronto.")
            break
        break  
    else:
        if i < INTENTOS - 1:
            print(f"Error. Te quedan {INTENTOS - i - 1} intentos.")
        else:
            print("Los intentos se han agotado. El acceso ha sido denegado")


