// See https://aka.ms/new-console-template for more information
//La compañía de videojuegos "ZEGA" está desarrollando un nuevo juego de rol (RPG) en el que los jugadores pueden encontrar objetos
//con diferentes valores. Necesitan un programa que permita identificar en qué posición se encuentran los objetos
//cuyo valor es mayor a un número dado.

//1. El programa solicitará al usuario que ingrese la cantidad de elementos (objetos) que desea analizar.
//2. Luego, pedirá al usuario que ingrese el valor mínimo que deben tener los objetos para ser considerados en el filtro.
//3. Seguidamente, el programa solicitará al usuario que ingrese los valores de los objetos, uno por uno.
//4. Una vez ingresados todos los valores, el programa mostrará al usuario las posiciones en las que se encuentran
//los objetos cuyo valor es mayor al número especificado.

int cantidadObjetos;
Console.Write("Ingrese la cantidad de objetos a analizar: ");
cantidadObjetos = int.Parse(Console.ReadLine());
Console.Write("Ingrese el valor mínimo para filtrar los objetos: ");
int valorMinimo = int.Parse(Console.ReadLine());
int[] objetos = new int[cantidadObjetos];
for (int i = 0; i < cantidadObjetos; i++)
{
    Console.Write("Ingrese el valor del objeto " + (i + 1) + ": ");
    objetos[i] = int.Parse(Console.ReadLine());

}
Console.WriteLine("Los objetos con valor mayor a " + valorMinimo + " se encuentran en las siguientes posiciones:");
for (int i = 0; i < cantidadObjetos; i++)
{
    if (objetos[i] > valorMinimo)
    {
        Console.WriteLine("Objeto en la posición " + i + " con valor " + objetos[i]);
    }
}
Console.ReadKey();