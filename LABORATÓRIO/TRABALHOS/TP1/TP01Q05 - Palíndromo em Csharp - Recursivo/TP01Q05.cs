using System;
using System.IO;

namespace TP01
{
    class Q01
    {
        public static Boolean isPalindromoRecursivo(String word, int i, int j)
        {
            Boolean resp = true;
            if (i < j)
            {
                if (word[i] == word[j])
                {
                    resp = isPalindromoRecursivo(word, ++i, --j);
                }
                else
                {
                    resp = false;
                    i = j;
                }

            }
            return resp;
        }

        static void Main(string[] args)
        {
            String linha = "";

            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(isPalindromoRecursivo(linha, 0, linha.Length - 1)? "SIM" : "NAO");
            }
        }
    }
}