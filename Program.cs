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