using System;
using System.IO;

namespace TP01
{
    class Q06
    {
        public static String ciframento(String word)
        {
            String resp = "";
            for (int i = 0; i < word.Length; i++)
            {
                resp += "" + ((char)((int)word[i] + 3));
            }
            return resp;
        }
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
        public static String ciframentoRecursivo(String word, int i)
        {
            String resp = "";

            while (i < word.Length)
            {
                resp += "" + ((char)((int)word[i] + 3));
                ciframentoRecursivo(""+word[i], ++i);
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
                    System.Console.WriteLine(ciframentoRecursivo(linha, 0));
            }
        }
    }
}