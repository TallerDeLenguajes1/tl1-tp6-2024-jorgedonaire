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
bool control;

do
{   
    Console.WriteLine("Ingrese numero a invertir:");
    numeroIngresado = Console.ReadLine();
    control = int.TryParse(numeroIngresado,out int numeroConvertido);
    if (control)
    {
        Console.WriteLine("El numero ingresado es: " + numeroConvertido);
        Console.WriteLine("El numero invertido es: ");
        if (control && numeroConvertido > 0)
        {
            do
            {
                Console.Write(numeroConvertido % 10);
                numeroConvertido = numeroConvertido / 10;
            } while (numeroConvertido > 9);

            Console.Write(numeroConvertido);    
        }
    }else
    {
        Console.WriteLine("ERROR. Ingrese un nÚmero");
    }    
} while (control != true);

Console.WriteLine();
//FIN EJERCICIO 1

//EJERCICIO 2
bool controlOperacion;
string numero1Ingresado, numero2Ingresado, repetirIngresado, repetirVerificado;
bool control1, control2;
int operacionConvertida, numero1Convertido, numero2Convertido;

Console.WriteLine("**** CALCULADORA V1 ****");
do
{
    do
    {   
        Console.WriteLine("--------------------------");
        Console.WriteLine("Ingrese la operación que desee:");
        Console.WriteLine("1 - Suma +");
        Console.WriteLine("2 - Resta -");
        Console.WriteLine("3 - Multiplicación *");
        Console.WriteLine("4 - División /");
        Console.WriteLine("--------------------------");

        string operacionIngresada  = Console.ReadLine();
        controlOperacion = int.TryParse(operacionIngresada,out operacionConvertida);
        if (controlOperacion && (operacionConvertida == 1 || operacionConvertida == 2 || operacionConvertida == 3 || operacionConvertida == 4))
        {
            Console.WriteLine("La opción elegida es: " + operacionConvertida);

            //Bloque de ingreso de numero 1
            do
            {   
                Console.WriteLine("Ingrese numero 1:");
                numero1Ingresado = Console.ReadLine();
                control1 = int.TryParse(numero1Ingresado,out numero1Convertido);
                if (control1)
                {
                    Console.WriteLine("El numero 1 ingresado es: " + numero1Convertido);
                }else
                {
                    Console.WriteLine("ERROR. Ingrese un numero");
                }    
            } while (control1 != true);
            //Fin bloque de ingreso de numero 1

            //Bloque de ingreso de numero 2
            do
            {   
                Console.WriteLine("Ingrese numero 2:");
                numero2Ingresado = Console.ReadLine();
                control2 = int.TryParse(numero2Ingresado,out numero2Convertido);
                if (control2)
                {
                    Console.WriteLine("El numero 2 ingresado es: " + numero2Convertido);
                }else
                {
                    Console.WriteLine("ERROR. Ingrese un número");
                }    
            } while (control2 != true);
            //Fin bloque de ingreso de numero 2


            switch (operacionConvertida)
            {
                case 1:
                    Console.WriteLine("El resultado es: "+ (numero1Convertido + numero2Convertido));
                break;
                case 2:
                    Console.WriteLine("El resultado es: "+ (numero1Convertido - numero2Convertido));
                break;
                case 3:
                    Console.WriteLine("El resultado es: "+ (numero1Convertido * numero2Convertido));
                break;
                case 4:
                    Console.WriteLine("El resultado es: "+ (numero1Convertido / numero2Convertido));
                break;
                default:

                break;
            }
        }else
        {
            Console.WriteLine("ERROR. Ingrese una opcion valida");
            controlOperacion = false;
        }    
    } while (controlOperacion != true);

Console.WriteLine("¿Desea realizar otra operacion?");
Console.WriteLine("s - SI | n - NO");
repetirIngresado = Console.ReadLine();
if (repetirIngresado == "s" || repetirIngresado == "n")
{
    repetirVerificado = repetirIngresado;
}else
{
    Console.WriteLine("Ingrese una opcion valida");
    repetirVerificado = "s";
}
} while (repetirVerificado == "s");

Console.Write("**** CALCULADORA V1 FINALIZADA ****");