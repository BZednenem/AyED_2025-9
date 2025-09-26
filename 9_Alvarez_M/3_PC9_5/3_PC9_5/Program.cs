using System;
class Program
{
    static void Main()
    {
        int hpHornet = 10;
        int hpMaxHornet = 10;
        int atkHornet = 3;
        int hpEnemigo = 12;
        Console.WriteLine("=== Hollow Knight: Simulador básico ===");
        while (hpHornet > 0 && hpEnemigo > 0)
        {
            MostrarEstado(hpHornet, hpEnemigo);
            Console.Write("\nAcción (atacar/curar/salir): ");
            string accion = Console.ReadLine();
            if (accion == "atacar")
            {
                hpEnemigo = Atacar(atkHornet, hpEnemigo);
            }
            else if (accion == "curar")
            {
                hpHornet = Curar(hpHornet, hpMaxHornet);
            }
            else if (accion == "salir")
            {
                break;
            }
            else
            {
                Console.WriteLine("Acción no válida.");
                
            
}
            // Enemigo ataca automáticamente
            if (hpEnemigo > 0)
            {
                hpHornet -= 2;
                Console.WriteLine("El enemigo contraataca y hace 2 de daño!");
            }
        }
        Console.WriteLine("\n=== Resultado ===");
        if (hpHornet <= 0) Console.WriteLine("Hornet ha caído...");
        else if (hpEnemigo <= 0) Console.WriteLine("¡Hornet ganó!");
        else Console.WriteLine("Batalla interrumpida.");
    }
    // -------------------
    // ACA DEBEN CREAR LAS FUNCIONES:
    // 1) Atacar
    static int Atacar(int atk, int hpEnemigo)
    {
        hpEnemigo -= atk;
        Console.WriteLine($"Hornet ataca y hace "+ atk+ "de daño!");
        return hpEnemigo;
    }
    // 2) Curar
    static int Curar(int hpHornet, int hpMaxHornet)
    {
        int cura = 5;
        hpHornet += cura;
        if (hpHornet > hpMaxHornet) hpHornet = hpMaxHornet;
        Console.WriteLine($"Hornet se cura "+ cura+ " puntos de vida!");
        return hpHornet;
    }
    // 3) MostrarEstado
    static void MostrarEstado(int hpHornet, int hpEnemigo)
    {
        Console.WriteLine($"\nHornet HP: "+ hpHornet);
        Console.WriteLine($"Enemigo HP: "+ hpEnemigo);
    }
    // -------------------
}