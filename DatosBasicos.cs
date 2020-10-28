using System;

namespace DatosBasicos
{
class Program{
static void Main(string[] args){
// 1)Preguntar al usuario su edad, que se guardará en un "byte". A continuación, se deberá le 
// deberá decir que no aparenta tantos años (por ejemplo, "No aparentas 20 años").
//2)Pedir al usuario dos números enteros largos ("long") y mostrar su suma, su resta y su producto.
//3)Crear un programa que use tres variables x,y,z. Sus valores iniciales serán 15, -10, 2.147.483.647. 
//Se deberá incrementar tres vece el valor de estas variables.
// Mostrar en pantalla el valor incial de las variables y el valor final obtenido por el programa.
//6)Calcular el área de un círculo, dado su radio (pi * radio al cuadrado).
/* 
1)
byte edad;
Console.WriteLine("Cuantos años tienes?");
edad = byte.Parse(Console.ReadLine());
Console.WriteLine("No aparentas {0} años",edad);
*/        
//2)
/*
long var1,var2,suma,resta,producto;

Console.WriteLine("Ingrese un numero:");
var1 = long.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero:");
var2 = long.Parse(Console.ReadLine());

Console.WriteLine("Suma {0}",suma=var1+var2);
Console.WriteLine("resta {0}",resta = var1-var2);
Console.WriteLine("producto {0}",producto = var1*var2);
*/
//3)
/*
int x = 5,y = -10;
double  z =  2.147483647;
Console.WriteLine("Valor inicial x({0}) y({1}) z({2})",x,y,z);
for (int i = 0; i <= 3; i++)
{
x++;
y++;
z++;    
}
Console.WriteLine("Valor final x({0}) y({1}) z({2})",x,y,z);
*/
//4)
/*
int  a=5,b,c; 
b=++a;
c=a++;
b=b*5;
a=a*2;
Console.WriteLine("Resultado A({0}) B({1}) C({2})",a,b,c);
*/ 
//5)
/*
int a,b,c;
a=5; b=a+2; b-=3;
c=-3; c*=2; ++c; 
a*=b;
Console.WriteLine("Resultado A({0}) B({1}) C({2})",a,b,c);
*/

//6)\
/*
double radio;
Console.WriteLine("Ingrese su radio: ");
radio = double.Parse(Console.ReadLine());
double resultado = radio * 3.14; 
Console.WriteLine(resultado);
*/


        }
    }
}
