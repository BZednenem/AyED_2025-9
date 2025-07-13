// See https://aka.ms/new-console-template for more information
int invitados;
int comida;
double sumaComida = 0;
double promedio;
Console.Write("Cuantos invitados van?");
invitados = int.Parse(Console.ReadLine());
for (int i = 1; i <= invitados; i++)
{
    do
    {
        Console.WriteLine("Cuanta comida comerá el invitado " + i + " (Entre 1 a 100)");
        comida = int.Parse(Console.ReadLine());
    } while (comida < 1 || comida > 100);
    sumaComida += comida;
}

promedio = sumaComida / invitados;
Console.WriteLine("El promedio de comida por invitado es de: " + promedio);
Console.ReadKey();