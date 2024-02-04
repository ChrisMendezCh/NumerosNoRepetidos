using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> NumerosNoRepetidos(List<int> numeros)
    {
        Dictionary<int, int> contador = new Dictionary<int, int>();

        foreach (int num in numeros)
        {
            if (contador.ContainsKey(num))
                contador[num]++;
            else
                contador[num] = 1;
        }

        return contador.Where(pair => pair.Value == 1).Select(pair => pair.Key).ToList();
    }

    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 2, 3, 4, 4, 5, 6, 6 };
        Console.WriteLine("Números que no se repiten:");
        foreach (int num in NumerosNoRepetidos(numeros))
        {
            Console.Write(num + " ");
        }
    }
}
