using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        // Divide a frase em palavras
        string[] palavras = frase.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        int maiusculas = 0;
        int minusculas = 0;
        int comLetraMaiuscula = 0;
        int comLetraMinuscula = 0;

        foreach (string palavra in palavras)
        {
            if (palavra.Length > 0)
            {
                if (char.IsUpper(palavra[0]))
                {
                    comLetraMaiuscula++;
                }
                else
                {
                    comLetraMinuscula++;
                }

                if (palavra == palavra.ToLower())
                {
                    minusculas++;
                }
                else if (palavra == palavra.ToUpper())
                {
                    maiusculas++;
                }
            }
        }

        int totalPalavras = palavras.Length;

        Console.WriteLine($"Palavras maiúsculas: {maiusculas}");
        Console.WriteLine($"Palavras minúsculas: {minusculas}");
        Console.WriteLine($"Palavras iniciando com letra maiúscula: {comLetraMaiuscula}");
        Console.WriteLine($"Palavras iniciando com letra minúscula: {comLetraMinuscula}");
        Console.WriteLine($"Total de palavras: {totalPalavras}");
    }
}
