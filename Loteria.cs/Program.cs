using System;
using System.Collections.Generic;

class Loteria
{
    static void Main()
    {
        List<int> awarded = new List<int>();

        // Pedir los números ganadores
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Introduce un número ganador: ");
            int number = int.Parse(Console.ReadLine());
            awarded.Add(number);
        }

        // Ordenar de menor a mayor
        awarded.Sort();

        // Mostrar resultados
        Console.WriteLine("Los números ganadores son " + string.Join(", ", awarded));
    }
}
