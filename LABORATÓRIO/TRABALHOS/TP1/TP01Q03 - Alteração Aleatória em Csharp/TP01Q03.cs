using System;
using System.IO;

namespace TP01
{
    class Q03
    {


        public static String ciframentoAleatorio(String word, char aleatorio1, char aleatorio2)
        {
            String resp = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == aleatorio1)
                {
                    resp += aleatorio2;
                }
                else
                {
                    resp += word[i];
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
            String linha = "";

            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(ciframentoAleatorio(linha, aleatorio1, aleatorio2));
            }
        }
    }
}