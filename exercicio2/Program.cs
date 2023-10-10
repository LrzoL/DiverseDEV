using System;

class Program
{
    static void Main()
    {
        //entrada de dados

        Console.Write("Digite o primeiro número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int multiplicacao = 0;
        int divisaoInteira = 0;
        int sinal = 1;

        // Verificação do sinal no resultado
        if ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0))
        {
            sinal = -1;
        }

        // Cálculo da multiplicação
        for (int i = 0; i < Math.Abs(n2); i++)
        {
            multiplicacao += Math.Abs(n1);
        }

        // Calcula a divisão inteira
        int temp = Math.Abs(n1);
        while (temp >= Math.Abs(n2))
        {
            temp -= Math.Abs(n2);
            divisaoInteira++;
        }

        // Aplicação do sinal
        multiplicacao *= sinal;
        divisaoInteira *= sinal;

        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão Inteira: {divisaoInteira}");
    }
}
