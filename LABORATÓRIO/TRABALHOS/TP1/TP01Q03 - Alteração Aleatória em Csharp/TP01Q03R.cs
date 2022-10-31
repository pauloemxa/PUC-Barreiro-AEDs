using System;
using System.IO;

namespace TP01
{
    class Q03R
    {
        public static String ciframentoAleatorio(String word, char aleatorio1, char aleatorio2, int i, String resp)
        {
            if (i < word.Length)
            {
                if (word[i] == aleatorio1)
                {
                    resp += aleatorio2 + ciframentoAleatorio(word, aleatorio1, aleatorio2, ++i, resp);
                }
                else
                {
                    resp += word[i] + ciframentoAleatorio(word, aleatorio1, aleatorio2, ++i, resp);
                }
            }
            return resp;
        }

        static void Main(string[] args)
        {
            Random gerador = new Random(4);
            char aleatorio1 = (char)('a' + (Math.Abs(gerador.Next()) % 26));
            char aleatorio2 = (char)('a' + (Math.Abs(gerador.Next()) % 26));

            System.Console.WriteLine("valores: " + aleatorio1 + " e " + aleatorio2);
            String linha = "", resp = "";
            int i = 0;

            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(ciframentoAleatorio(linha, aleatorio1, aleatorio2, i, resp));
            }
        }
    }
}