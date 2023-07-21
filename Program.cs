using System;

public class Numerologia
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra...");
        string palavra = Console.ReadLine().ToLower(); 
        while (!string.IsNullOrEmpty(palavra))
        {
            int valorNumerologico = CalcularValorNumerologico(palavra);
            Console.WriteLine($"\n Valor da palavra \"{palavra}\" é: {valorNumerologico} \n \n  Digite outra palavra para continuar ou Pressione <ENTER> para finalizar ...");
            palavra = Console.ReadLine().ToLower();
        }

    }

    static int CalcularValorNumerologico(string palavra)
    {
        int valorTotal = 0;
        foreach (char letra in palavra)
        {
            int valorLetra = ObterValorLetra(letra);
            valorTotal += valorLetra;
        }
        return valorTotal;
    }

    static int ObterValorLetra(char letra)
    {
        // Tabela de valores numéricos para cada letra
        // Pode-se adicionar mais letras e valores, se necessário
        switch (letra)
        {
            case 'a': return 1;
            case 'b': return 2;
            case 'c': return 3;
            case 'd': return 4;
            case 'e': return 5;
            case 'f': return 6;
            case 'g': return 7;
            case 'h': return 8;
            case 'i': return 9;
            case 'j': return 1;
            case 'k': return 2;
            case 'l': return 3;
            case 'm': return 4;
            case 'n': return 5;
            case 'o': return 6;
            case 'p': return 7;
            case 'q': return 8;
            case 'r': return 9;
            case 's': return 1;
            case 't': return 2;
            case 'u': return 3;
            case 'v': return 4;
            case 'w': return 5;
            case 'x': return 6;
            case 'y': return 7;
            case 'z': return 8;
            default: return 0; // Tratar caracteres que não sejam letras como 0
        }
    }

}
