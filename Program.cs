// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

// Console.WriteLine("Hello, World!");

// int a;
// int b;
// a = 10;
// b = a;

// Console.WriteLine("Valor de a: " +a);
// Console.WriteLine("Valor de b: " +b);

// string numeroIngresado;
// bool control;

// do
// {   
//     Console.WriteLine("Ingrese numero a invertir:");
//     numeroIngresado = Console.ReadLine();
//     control = int.TryParse(numeroIngresado,out int numeroConvertido);
//     if (control)
//     {
//         Console.WriteLine("El numero ingresado es: " + numeroConvertido);
//         Console.WriteLine("El numero invertido es: ");
//         if (control && numeroConvertido > 0)
//         {
//             do
//             {
//                 Console.Write(numeroConvertido % 10);
//                 numeroConvertido = numeroConvertido / 10;
//             } while (numeroConvertido > 9);

//             Console.Write(numeroConvertido);    
//         }
//     }else
//     {
//         Console.WriteLine("ERROR. Ingrese un nÚmero");
//     }    
// } while (control != true);

// Console.WriteLine();
// //FIN EJERCICIO 1

// //EJERCICIO 2
// bool controlOperacion;
// string numero1Ingresado, numero2Ingresado, repetirIngresado, repetirVerificado;
// bool control1, control2;
// int operacionConvertida, numero1Convertido, numero2Convertido;

// Console.WriteLine("**** CALCULADORA V1 ****");
// do
// {
//     do
//     {   
//         Console.WriteLine("--------------------------");
//         Console.WriteLine("Ingrese la operación que desee:");
//         Console.WriteLine("1 - Suma +");
//         Console.WriteLine("2 - Resta -");
//         Console.WriteLine("3 - Multiplicación *");
//         Console.WriteLine("4 - División /");
//         Console.WriteLine("--------------------------");

//         string operacionIngresada  = Console.ReadLine();
//         controlOperacion = int.TryParse(operacionIngresada,out operacionConvertida);
//         if (controlOperacion && (operacionConvertida == 1 || operacionConvertida == 2 || operacionConvertida == 3 || operacionConvertida == 4))
//         {
//             Console.WriteLine("La opción elegida es: " + operacionConvertida);

//             //Bloque de ingreso de numero 1
//             do
//             {   
//                 Console.WriteLine("Ingrese numero 1:");
//                 numero1Ingresado = Console.ReadLine();
//                 control1 = int.TryParse(numero1Ingresado,out numero1Convertido);
//                 if (control1)
//                 {
//                     Console.WriteLine("El numero 1 ingresado es: " + numero1Convertido);
//                 }else
//                 {
//                     Console.WriteLine("ERROR. Ingrese un numero");
//                 }    
//             } while (control1 != true);
//             //Fin bloque de ingreso de numero 1

//             //Bloque de ingreso de numero 2
//             do
//             {   
//                 Console.WriteLine("Ingrese numero 2:");
//                 numero2Ingresado = Console.ReadLine();
//                 control2 = int.TryParse(numero2Ingresado,out numero2Convertido);
//                 if (control2)
//                 {
//                     Console.WriteLine("El numero 2 ingresado es: " + numero2Convertido);
//                 }else
//                 {
//                     Console.WriteLine("ERROR. Ingrese un número");
//                 }    
//             } while (control2 != true);
//             //Fin bloque de ingreso de numero 2


//             switch (operacionConvertida)
//             {
//                 case 1:
//                     Console.WriteLine("El resultado es: "+ (numero1Convertido + numero2Convertido));
//                 break;
//                 case 2:
//                     Console.WriteLine("El resultado es: "+ (numero1Convertido - numero2Convertido));
//                 break;
//                 case 3:
//                     Console.WriteLine("El resultado es: "+ (numero1Convertido * numero2Convertido));
//                 break;
//                 case 4:
//                     Console.WriteLine("El resultado es: "+ (numero1Convertido / numero2Convertido));
//                 break;
//                 default:

//                 break;
//             }
//         }else
//         {
//             Console.WriteLine("ERROR. Ingrese una opcion valida");
//             controlOperacion = false;
//         }    
//     } while (controlOperacion != true);

// Console.WriteLine("¿Desea realizar otra operacion?");
// Console.WriteLine("s - SI | n - NO");
// repetirIngresado = Console.ReadLine();
// if (repetirIngresado == "s" || repetirIngresado == "n")
// {
//     repetirVerificado = repetirIngresado;
// }else
// {
//     Console.WriteLine("Ingrese una opcion valida");
//     repetirVerificado = "s";
// }
// } while (repetirVerificado == "s");

// Console.Write("**** CALCULADORA V1 FINALIZADA ****");
// //EJERCICIO 3
// string numero3Ingresado, numero4Ingresado, numero5Ingresado;
// bool controlNumero3, controlNumero4, controlNumero5;
// float numero3Convertido;
// int numero4Convertido, numero5Convertido;
// Console.WriteLine(" **** INICIO CALCULADORA V2 ****");
// do
// {
//     Console.WriteLine("Ingrese un numero: ");
//     numero3Ingresado = Console.ReadLine();
//     controlNumero3 = float.TryParse(numero3Ingresado, out numero3Convertido);
//     if (controlNumero3)
//     {
//         Console.WriteLine("El valor absoluto es: " + Math.Abs(numero3Convertido));
//         Console.WriteLine("El cuadrado es: " + Math.Pow(numero3Convertido,2));
//         Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(numero3Convertido));
//         Console.WriteLine("El seno es: " + Math.Sin(numero3Convertido));
//         Console.WriteLine("El coseno es: " + Math.Cos(numero3Convertido));
//         Console.WriteLine("La parte entero es: " + Math.Round(numero3Convertido,0));
//     }else
//     {
//         Console.WriteLine("ERROR. Ingrese un numero");
//         controlNumero3 = false;
//     }
// } while (controlNumero3 != true);

// do
// {
//     Console.WriteLine("Ingrese el numero 1: ");
//     numero4Ingresado = Console.ReadLine();
//     controlNumero4 = int.TryParse(numero4Ingresado,out numero4Convertido);
//     if (controlNumero4)
//     {
//         do
//         {
//             Console.WriteLine("Ingrese el numero 2: ");
//             numero5Ingresado = Console.ReadLine();
//             controlNumero5 = int.TryParse(numero5Ingresado,out numero5Convertido);
//             if (controlNumero5)
//             {
//                 Console.WriteLine("El maximo valor es:" + Math.Max(numero4Convertido,numero5Convertido));
//                 Console.WriteLine("El minimo valor es:" + Math.Min(numero4Convertido,numero5Convertido));
//             }else
//             {
//                 Console.WriteLine("ERROR. Ingrese un numero");        
//             }
//         } while (controlNumero5 != true);

//     }else
//     {
//         Console.WriteLine("ERROR. Ingrese un numero");
//     }
// } while (controlNumero4 != true);
// Console.WriteLine(" **** FIN CALCULADORA V2 ****");

//EJERCICIO 4
string cadenaIngresada1, cadenaIngresada2, cadenaConcatenada;
Console.WriteLine("Ingrese una cadena de texto: ");
cadenaIngresada1 = Console.ReadLine();

//Obtener la longitud de una cadena
Console.WriteLine("La longitud de la cadena es: " + cadenaIngresada1.Length);
Console.WriteLine($"La longitud de la cadena es: {cadenaIngresada1.Length}"); //Otra forma 

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
Console.WriteLine("Ingrese otra cadena de texto: ");
cadenaIngresada2 = Console.ReadLine();

cadenaConcatenada = string.Concat(cadenaIngresada1,cadenaIngresada2);
Console.WriteLine($"La cadena concatenada es: {cadenaConcatenada}");
Console.WriteLine($"La cadena concatenada es: {string.Concat(cadenaIngresada1,cadenaIngresada2)}");
Console.WriteLine($"La cadena concatenada es: " + cadenaIngresada1 + cadenaIngresada2); //Otra forma

//Extraer una subcadena de la cadena ingresada

Console.WriteLine("La subcadena extraida desde la posicion 6 en adelante es: "+ cadenaConcatenada.Substring(6));

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
Console.WriteLine("La cadena recorrida por un foreach es: ");
foreach (var letra in cadenaConcatenada)
{
    Console.WriteLine(" "+letra+" ");
}

//Buscar la ocurrencia de una palabra determinada en la cadena ingresada

string palabraBuscada;
Console.WriteLine("Ingrese la palabra buscada: ");
palabraBuscada = Console.ReadLine();
if (cadenaConcatenada.Contains(palabraBuscada))
{
    Console.WriteLine("La palabra ingresada SI pertenece a la cadena");
}else
{
    Console.WriteLine("La palabra ingresada NO se encontro en la cadena");
}

//Convierta la cadena a mayúsculas y luego a minúsculas

Console.WriteLine("Cadena convertida a mayusculas");
string cadenaMayusculas = cadenaConcatenada.ToUpper();
Console.WriteLine(cadenaMayusculas);

Console.WriteLine("Cadena convertida a minusculas");
string cadenaMinusculas = cadenaConcatenada.ToLower();
Console.WriteLine(cadenaMinusculas);

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())

Console.WriteLine("Ingrese una cadena separada por guiones (-) :");
string cadenaConSeparadores = Console.ReadLine();
string [] palabrasSeparadas = cadenaConSeparadores.Split('-');

foreach (var palabra in palabrasSeparadas)
{
    Console.WriteLine(palabra);
}

//Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese por pantalla “582+2” y que le devuelva la suma de 582 con 2
