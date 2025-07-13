// See https://aka.ms/new-console-template for more information
//El promedio de las notas de los exámenes debe ser mayor o igual a 6.
//
//Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.
//
//El promedio de las notas de los exámenes debe ser mayor o igual a 6.
//
//Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.
//
//Permitir al usuario ingresar las notas de cada TP y examen.
//
//Calcular el promedio de las notas de los exámenes.
//
//Verificar si se cumplen las condiciones para aprobar la materia.
//
//Mostrar un mensaje indicando si Phineas y Ferb pueden aprobar la materia.

int cTP = 0;
int cExamen = 0;
int notaTP = 0;
int notaExamen = 0;
int sumaTP = 0;
int sumaExamen = 0;
int aprobadosTP = 0;
int aprobadosExamen = 0;
Console.WriteLine("Ingrese la cantidad de TPs:");
cTP = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de Exámenes:");
cExamen = int.Parse(Console.ReadLine());
for (int i = 0; i < cTP; i++)
{
    Console.WriteLine($"Ingrese la nota del TP {i + 1}:");
    notaTP = int.Parse(Console.ReadLine());
    sumaTP += notaTP;
    if (notaTP >= 6)
    {
        aprobadosTP++;
    }
}
for (int i = 0; i < cExamen; i++)
{
    Console.WriteLine($"Ingrese la nota del Examen {i + 1}:");
    notaExamen = int.Parse(Console.ReadLine());
    sumaExamen += notaExamen;
    if (notaExamen >= 6)
    {
        aprobadosExamen++;
    }
}
double promedioExamen = (double)sumaExamen / cExamen;
double promedioTP = (double)sumaTP / cTP;
if (promedioExamen >= 6 && (double)aprobadosTP / cTP >= 0.75)
{
    Console.WriteLine("Phineas y Ferb pueden aprobar la materia.");
}
else
{
    Console.WriteLine("Phineas y Ferb no pueden aprobar la materia.");
}
// Fin del programa
