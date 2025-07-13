// See https://aka.ms/new-console-template for more information
//Durante el evento de ventas "Hot Sale", una tienda en línea desea conocer cuál fue el producto más caro y el más económico
//que se vendió durante el evento.

//1. El programa solicitará al usuario que ingrese la cantidad de productos vendidos durante el Hot Sale.
//2. Luego, pedirá al usuario que ingrese el precio de cada producto, uno por uno.
//3. Una vez ingresados todos los precios, el programa determinará cuál fue el precio más alto y cuál fue el precio más bajo.
//4. Finalmente, mostrará al usuario los precios más alto y más bajo registrados durante el evento.

int cantidadProductos;
int precioProducto;
int precioMaximo = int.MinValue;
int precioMinimo = int.MaxValue;

Console.Write("Ingrese la cantidad de productos vendidos durante el Hot Sale: ");
cantidadProductos = int.Parse(Console.ReadLine());

for (int i = 0; i < cantidadProductos; i++)
{
    Console.Write($"Ingrese el precio del producto {i + 1}: ");
    precioProducto = int.Parse(Console.ReadLine());
    if (precioProducto > precioMaximo)
    {
        precioMaximo = precioProducto;
    }
    if (precioProducto < precioMinimo)
    {
        precioMinimo = precioProducto;
    }
}
Console.WriteLine($"El precio más alto registrado durante el Hot Sale es: {precioMaximo}");
Console.WriteLine($"El precio más bajo registrado durante el Hot Sale es: {precioMinimo}");

