using System;
using System.IO;

namespace TP01
{
    class Q01
    {
        public static String isPalindromoRecursivo(String word, int i, int j)
        {
            Boolean resp = false;
            while (i < j)
            {
                if (word[i] == word[j])
                {
                    isPalindromoRecursivo(word, ++i, --j);
                    resp = true;
                }
                else
                {
                    resp = false;
                    i = j;
                }

            }
            return resp ? "SIM" : "NAO";
        }

        static void Main(string[] args)
        {
            String linha = "";

            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(isPalindromoRecursivo(linha, 0, linha.Length - 1));
            }
        }
    }
}