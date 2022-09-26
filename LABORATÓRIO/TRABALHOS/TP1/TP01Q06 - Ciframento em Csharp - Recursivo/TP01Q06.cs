using System;
using System.IO;

namespace TP01
{
    class Q06
    {
        public static String ciframentoRecursivo(String resp, String word, int i)
        {
            if (i < word.Length)
            {
                resp += ((char)((int)word[i] + 3)) + ciframentoRecursivo(resp, word, ++i);
            }

            return resp;
        }

        static void Main(string[] args)
        {
            String linha = "";
            String resp = "";
            
            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(ciframentoRecursivo(resp, linha, 0));
            }
        }
    }
}