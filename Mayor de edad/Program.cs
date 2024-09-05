/*Console.WriteLine("Ingrese un valor");
String numeroIngresado = Console.ReadLine();
int numero ;

if (int.TryParse(numeroIngresado, out numero))
{
Console.WriteLine("EL numero ingresado" + numero + "+" + 1 + "=" + (numero + 1));

if(numero>15 && numero <= 50)
{
Console.WriteLine("El numero es mayor a 15");
}
else
{
    Console.WriteLine("El numero no se encuentra en el rango");
}
}
else
{
    Console.WriteLine("El valor no es numerico");
}


int horasTrabajadas = 48;
        decimal valorHora = 5000;
        decimal porcentajeRetencion = 12.5m;

        decimal salarioBasico = horasTrabajadas * valorHora * 4;
        decimal retencionFuente = salarioBasico * (porcentajeRetencion / 100);
        decimal salarioNeto = salarioBasico - retencionFuente;

        Console.WriteLine("Salario Básico: $" + salarioBasico);
        Console.WriteLine("Retención en la Fuente: $" + retencionFuente);
        Console.WriteLine("Salario Neto: $" + salarioNeto);


string fruta = "uva";
switch(fruta)
{
    case "fresa":
    Console.WriteLine($"la {fruta} tienete un descuento de 5%");
         break ; 
    case "uva":
    Console.WriteLine($"la {fruta} tienete un descuento de 10%");
    break;
    default:
    Console.WriteLine($"la fruta {fruta} no tiene descuento");
        break;

}



for (int tabla = 1; tabla <= 10; tabla++)
        {
            Console.WriteLine("Tabla del {0}:", tabla);
            
        
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                int resultado = tabla * multiplicador;
                Console.WriteLine("{0} x {1} = {2}", tabla, multiplicador, resultado);
            }
            
            Console.WriteLine(); 
        }*/


  /*for(int i = 1; i <=5; i++)
{
    Console.WriteLine($"ingrese el nombre del estudiante");
string nombre = Console.ReadLine();
Console.WriteLine($"El nombre ingresado es {nombre}");
}2
Console.WriteLine($"ya termino el ciclo");*/

//ejemplo:
// int x = 0;
//  Console.WriteLine($"Ingrese un numero");
//  string numeroIngresado = Console.ReadLine();
//  int numero;

//  while (!int.TryParse(numeroIngresado, out numero))
//  {
//      Console.WriteLine($"Ingrese un numero");
//     numeroIngresado = Console.ReadLine();
//  }
//  Console.WriteLine($"{numeroIngresado}");

// int n = 5;
// while (n < 5)
// {
//     Console.WriteLine($"{n}");
//     n++;
// }

// do
// {
//     Console.WriteLine($"{n}");
//     n++;

// } while (n < 5);

// do
// {
//     Console.WriteLine($"Ingrese un numero");
//     numeroIngresado = Console.ReadLine();
// }while (!int.TryParse(numeroIngresado, out numero));

// int num = 2;
// void Suma(int num1, int num2)
// {
//     num++;
//     Console.WriteLine($"{num1 + num2}");
//     Console.WriteLine($"{num}");

// }
// Suma(2, 5);
// Suma(3, 9);
// Suma(4, 4);
// Suma(7, 1);

// int Suma2(int num1, int num2)
// {
//     return num1 + num2;
// }
// int resultado1 = Suma2(2, 5);
// //Console.WriteLine($"{Suma2(3, 1)+1}");
// int suma = resultado1 + 1;
// Console.WriteLine($"{suma}");

// void Saludar(string nombre)
// {
//     Console.WriteLine($"Hola {nombre}");
// }

// Console.WriteLine($"Ingrese su nombre");
// string nombreUsuario = Console.ReadLine();

// Saludar(nombreUsuario);

// void Saludar2()
// {
//     Console.WriteLine($"Ingrese su nombre");
//     string nombre = Console.ReadLine();

//     Console.WriteLine($"Ingrese su edad");
//     string edad = Console.ReadLine();

//     Console.WriteLine($"Hola {nombre}, tienes {edad} años");
// }

// Saludar2();


// int num = 0;

// void Incrementar()
// {
//     num++;
// }

// void Decrementar()
// {
//     num--;
// }

// Incrementar();
// Console.WriteLine(num);
// Incrementar();
// Console.WriteLine(num);
// Incrementar();
// Console.WriteLine(num);
// Incrementar();
// Console.WriteLine(num);

// Decrementar();
// Console.WriteLine(num);
// Decrementar();
// Console.WriteLine(num);
// Decrementar();
// Console.WriteLine(num);
// Decrementar();
// Console.WriteLine(num);


// string Saludar(string nombre)
// {
//     string saludo = "Hola " + nombre;
//     return saludo;
// }

// string saludo  = Saludar("Pepe");
// Console.WriteLine($"{saludo + " feliz tarde"}");

// saludo = Saludar("Mario");
// Console.WriteLine($"{saludo}");

// Console.WriteLine($"{Saludar("Fulano")}");

// int Suma(int n1, int n2)
// {
//     return n1 + n2;
// }
// int resultado = Suma(1, 2);

// int suma = resultado + 1;
// Console.WriteLine(suma);

// string SolicitarNombre()
// {
//     Console.WriteLine("Ingrese su nombre");
//     string nombre = Console.ReadLine();
//     return nombre;
// }

// string nombre1 = SolicitarNombre();
// string nombre2 = SolicitarNombre();

// Console.WriteLine("Los nombres ingresados son:");
// Console.WriteLine(nombre1.ToUpper()); //pasa el texto a mayuscula
// Console.WriteLine(nombre2.ToLower()); //pasa el texto a minuscula

/*Console.WriteLine("Ingrese su edad: ");
string edad = Console.ReadLine();
int edad; 
(int.TryParse(edad, out numero))

int pulsaciones = 220;
        decimal calculo= pulsaciones - edad;
        decimal pulsacionesDebidas = calculo/10*/


//Ejercicio en clase:
// Console.WriteLine("Ingrese un numero entero: ");
// int A = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese un numero entero: ");
// int B = int.Parse(Console.ReadLine());

// int suma = A + B;

// Console.WriteLine("Suma: " + suma);

//Ejemplo del anterior ejercicio(forma larga)

// int num1;
// int num2;
// int suma;
// string linea;
       
// Console.writeLine("Ingrese dos numeros enteros y los suma");
     
// Console.WriteLine("Ingresar el primer numero entero");
// linea = Console.WriteLine("Ingresar el segundo numero entero");
// linea = Console.ReadLine();
// num2=int.Parse(linea);

// suma = num1 + num2;

// Console.Write("El total de la suma de los dos numeros ingresados es: " + suma);


//Ejemplo del anterior ejercicio(forma corta)

/*int num1, num2, suma;

Console.WriteLine("Ingresae dos numeros enteros y sumar.");
Console.WriteLine("Ingresar el primer numero entero: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresar el segundo numero: ");
num2 = int.Parse(Console.ReadLine());

suma = num1 + num2;

Console.Write("La suma de los numeros enteros es: " + suma);*/


// using System;
// internal class Program
// {
//     private static void Main(stri)
// }
// int num1, num2, resultado;
//     const int constante = 5;
//     string linea;
    
//     Console.WriteLine("Ingresar dos numeros enteros");
//     Console.WriteLine("Ingresar el primer numero entero: ");
//     linea = Console.ReadLine();
//     num1 = int.Parse(linea);
    
//     Console.Write("Ingresar el segundo numero entero: ");
//     linea = Console.ReadLine();
//     num2 = int.Parse(linea);
    
//   resultado = (num1 + num2) * constante;
    
//  Console.WriteLine("El resultado es: " + resultado);

// using System;
// internal class Program
// {
//     private static void Main(string[]args)
//     {
//         if (args is null)
//         {
//             throw new ArgumentNullException(nameof(args));
//         }
        
//         int resultado;
//         const int constante = 5;

//         Console.WriteLine("Ingresar dos numeros enteros y multiplicar por 5");
//         Console.WriteLine("Ingresar el primer numero entero: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());
        
//         Console.WriteLine("Ingresar el segundo numero entero: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());

//         resultado = ((num1 + num2) * constante);

//         Console.WriteLine("El resultado es: " + resultado);

//     }

// }    

     