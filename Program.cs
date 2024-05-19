// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a: " +a);
Console.WriteLine("Valor de b: " +b);

string numeroIngresado;
int numeroConvertido;

Console.WriteLine("Ingrese el numero a invertir: ");
numeroIngresado = Console.ReadLine();
bool resultado = int.TryParse(numeroIngresado,out numeroConvertido);

Console.WriteLine("El numero ingresado es " + numeroConvertido);

Console.WriteLine("El numero invertido es: ");

if (resultado && numeroConvertido > 0)
{
    do
    {
        Console.Write(numeroConvertido % 10);
        numeroConvertido = numeroConvertido / 10;
    } while (numeroConvertido > 9);

    Console.Write(numeroConvertido);    
}

//FIN EJERCICIO 1

//EJERCICIO 2
//EJERCICIO 3
string numero3Ingresado, numero4Ingresado, numero5Ingresado;
bool controlNumero3, controlNumero4, controlNumero5;
float numero3Convertido;
int numero4Convertido, numero5Convertido;
Console.WriteLine(" **** INICIO CALCULADORA V2 ****");
do
{
    Console.WriteLine("Ingrese un numero: ");
    numero3Ingresado = Console.ReadLine();
    controlNumero3 = float.TryParse(numero3Ingresado, out numero3Convertido);
    if (controlNumero3)
    {
        Console.WriteLine("El valor absoluto es: " + Math.Abs(numero3Convertido));
        Console.WriteLine("El cuadrado es: " + Math.Pow(numero3Convertido,2));
        Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(numero3Convertido));
        Console.WriteLine("El seno es: " + Math.Sin(numero3Convertido));
        Console.WriteLine("El coseno es: " + Math.Cos(numero3Convertido));
        Console.WriteLine("La parte entero es: " + Math.Round(numero3Convertido,0));
    }else
    {
        Console.WriteLine("ERROR. Ingrese un numero");
        controlNumero3 = false;
    }
} while (controlNumero3 != true);

do
{
    Console.WriteLine("Ingrese el numero 1: ");
    numero4Ingresado = Console.ReadLine();
    controlNumero4 = int.TryParse(numero4Ingresado,out numero4Convertido);
    if (controlNumero4)
    {
        do
        {
            Console.WriteLine("Ingrese el numero 2: ");
            numero5Ingresado = Console.ReadLine();
            controlNumero5 = int.TryParse(numero5Ingresado,out numero5Convertido);
            if (controlNumero5)
            {
                Console.WriteLine("El maximo valor es:" + Math.Max(numero4Convertido,numero5Convertido));
                Console.WriteLine("El minimo valor es:" + Math.Min(numero4Convertido,numero5Convertido));
            }else
            {
                Console.WriteLine("ERROR. Ingrese un numero");        
            }
        } while (controlNumero5 != true);

    }else
    {
        Console.WriteLine("ERROR. Ingrese un numero");
    }
} while (controlNumero4 != true);
Console.WriteLine(" **** FIN CALCULADORA V2 ****");
