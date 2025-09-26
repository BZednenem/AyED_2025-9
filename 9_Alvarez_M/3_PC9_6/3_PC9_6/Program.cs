using System;
using System.Linq;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");
        // 1) Generar mano aleatoria
        string[] mano = GenerarManoAleatoria();
        // 2) Determinar tipo de mano
        string tipo = TipoDeMano(mano);
        // 3) Calcular puntaje base

        
    
int basePts = PuntajeBase(mano);
        // 4) Obtener multiplicador
        double mult = Multiplicador(tipo);
        // 5) Calcular puntaje final
        double total = basePts * mult;
        // 6) Aplicar jokers
        bool jokerX2 = true;
        bool jokerMas10 = true;
        total = AplicarJokers(total, jokerX2, jokerMas10);
        // 7) Mostrar resumen final
        MostrarResumen(mano, tipo, basePts, mult, total);
    }
    // ⚠️ Todas las funciones que se llaman en el Main
    // deben ser creadas acá abajo por ustedes.

    //1)
    static string[] GenerarManoAleatoria()
    {
        
        string[] valores = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3","2" };
        Random rand = new Random();

        string[] palos = { "H", "D", "C", "S" };
        Random rand2 = new Random();

        return Enumerable.Range(0, 5).Select(_ => valores[rand.Next(valores.Length)] + palos[rand2.Next(palos.Length)]).ToArray();
    }

    //2
    static string TipoDeMano(string[] mano)
    {
        return "TipoEjemplo"; 
    }

    //3
    static int PuntajeBase(string[] mano)
    {
        int puntaje = 0;
        foreach (string carta in mano)
        {
            char valor = carta[0];
            switch (valor)
            {
                case 'A':
                    puntaje += 14;
                    break;
                case 'K':
                    puntaje += 13;
                    break;
                case 'Q':
                    puntaje += 12;
                    break;
                case 'J':
                    puntaje += 11;
                    break;
                case 'T':
                    puntaje += 10;
                    break;
                case '9':
                    puntaje += 9;
                    break;
                case '8':
                    puntaje += 8;
                    break;
                case '7':
                    puntaje += 7;
                    break;
                case '6':
                    puntaje += 6;
                    break;
                case '5':
                    puntaje += 5;
                    break;
                case '4':
                    puntaje += 4;
                    break;
                case '3':
                    puntaje += 3;
                    break;
                case '2':
                    puntaje += 2;
                    break;
            }
        }
        return puntaje;
    }

    //4
    static double Multiplicador(string tipo)
    {
        return tipo switch
        {
            "Nada" => 1.0,
            "Par" => 1.5,
            "Trio" => 2.5,
            "Full" => 3.5,
            "Poker" => 4.0,
            _ => 1.0
        };
    }


    //5
    static double AplicarJokers(double total, bool jokerX2, bool jokerMas10)
    {
        if (jokerX2)
        {
            total *= 2;
        }
        if (jokerMas10)
        {
            total += 10;
        }
        return total;
    }

    //6
    static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
    {
        Console.WriteLine("Mano: " + string.Join(" ", mano));
        Console.WriteLine("Tipo: " + tipo);
        Console.WriteLine("Puntaje base: " + basePts);
        Console.WriteLine("Multiplicador: x" + mult);
        Console.WriteLine("Total (con Jokers): " + total);
    }




}