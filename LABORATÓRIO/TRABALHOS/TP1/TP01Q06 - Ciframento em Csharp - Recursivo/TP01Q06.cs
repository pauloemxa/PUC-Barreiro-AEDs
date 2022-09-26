using System;
using System.IO;

namespace TP01
{
    class Q06
    {
<<<<<<< HEAD
        public static String ciframentoRecursivo(String resp, String word, int i)
        {
            if (i < word.Length)
            {
                resp += ((char)((int)word[i] + 3)) + ciframentoRecursivo(resp, word, ++i);
            }
=======
        public static String ciframentoRecursivo(String word, int i)
        {
            String resp = "";

            while (i < word.Length)
                resp += ((char)((int)word[i] + 3)) + ciframentoRecursivo("" + word[i], ++i);
>>>>>>> 298a171788e3588f15b18db3fc4158dd7080747b

            return resp;
        }

        static void Main(string[] args)
        {
            String linha = "";
<<<<<<< HEAD
            String resp = "";
            
=======

>>>>>>> 298a171788e3588f15b18db3fc4158dd7080747b
            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(ciframentoRecursivo(resp, linha, 0));
            }
        }
    }
}