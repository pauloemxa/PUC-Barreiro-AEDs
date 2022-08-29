using System;
using System.IO;

namespace TP01
{
    class Q06
    {
        public static String ciframentoRecursivo(String word, int i)
        {
            String resp = "";

            while (i < word.Length)
                resp += ((char)((int)word[i] + 3)) + ciframentoRecursivo("" + word[i], ++i);

            return resp;
        }

        static void Main(string[] args)
        {
            String linha = "";

            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(ciframentoRecursivo(linha, 0));
            }
        }
    }
}