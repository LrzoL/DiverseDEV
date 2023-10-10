

using System;

class Program
{
    static void Main()
    {
        int[] valores = new int[5];
        int pares = 0, impares = 0, positivos = 0, negativos = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());

            if (valores[i] % 2 == 0)
                pares++;
            else
                impares++;

            if (valores[i] > 0)
                positivos++;
            else if (valores[i] < 0)
                negativos++;
        }

        Console.WriteLine($"Quantidade de valores pares: {pares}");
        Console.WriteLine($"Quantidade de valores ímpares: {impares}");
        Console.WriteLine($"Quantidade de valores positivos: {positivos}");
        Console.WriteLine($"Quantidade de valores negativos: {negativos}");
    }
}

