using System;
using System.Collections.Generic;

class NotasCurso
{
    static void Main()
    {
        List<string> subjects = new List<string>
        {
            "Matematicas",
            "Fisica",
            "Quimica",
            "Historia",
            "Lengua"
        };

        List<string> scores = new List<string>();

        // Pedir las notas
        foreach (string subject in subjects)
        {
            Console.Write("¿Qué nota has sacado en " + subject + "? ");
            string score = Console.ReadLine();
            scores.Add(score);
        }

        Console.WriteLine();

        // Mostrar resultados
        for (int i = 0; i < subjects.Count; i++)
        {
            Console.WriteLine("En " + subjects[i] + " has sacado " + scores[i]);
        }
    }
}
