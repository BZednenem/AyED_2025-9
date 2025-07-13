// See https://aka.ms/new-console-template for more information
//En la empresa de videojuegos "Pixel Dreams", se está organizando un torneo en línea de su juego más popular, "Galaxy Quest".
//Para determinar los ganadores, necesitan un programa que ordene los puntajes de los jugadores de mayor a menor.
//El programa solicitará al usuario que ingrese la cantidad de participantes en el torneo.Luego,
//pedirá al usuario que ingrese los puntajes de cada participante, uno por uno.Una vez ingresados todos los puntajes,
//el programa los ordenará de mayor a menor.Finalmente, mostrará la lista de puntajes ordenados,
//indicando el primer lugar (mayor puntaje) y el último lugar (menor puntaje).

int cantidadParticipantes;
Console.WriteLine("Bienvenido al torneo de 'Galaxy Quest' de Pixel Dreams.");
Console.Write("Ingrese la cantidad de participantes: ");
cantidadParticipantes = int.Parse(Console.ReadLine()!);
int[] puntajes = new int[cantidadParticipantes];
for (int i = 0; i < cantidadParticipantes; i++)
{
    Console.Write($"Ingrese el puntaje del participante {i + 1}: ");
    puntajes[i] = int.Parse(Console.ReadLine()!);
}
Array.Sort(puntajes);
Array.Reverse(puntajes);
Console.WriteLine("\nPuntajes ordenados de mayor a menor:");
for (int i = 0; i < puntajes.Length; i++)
{
    Console.WriteLine($"Participante {i + 1}: {puntajes[i]} puntos");
}
Console.WriteLine($"Primer lugar: Participante 1 con {puntajes[0]} puntos");
Console.WriteLine($"Último lugar: Participante {puntajes.Length} con {puntajes[puntajes.Length - 1]} puntos");
Console.WriteLine("¡Gracias por participar en el torneo de 'Galaxy Quest'!");
Console.ReadKey();