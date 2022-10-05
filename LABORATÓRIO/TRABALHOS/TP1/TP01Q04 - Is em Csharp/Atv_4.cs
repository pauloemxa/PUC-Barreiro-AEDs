using System;
using System.IO;

namespace Atv_4
{
    class Program
    {
        public static Boolean IsVogal(char c)
        {
            Boolean resp = false;
            string vogais = "aeiouAEIOU";

            for (int i = 0; i < vogais.Length; i++)
            {
                if (vogais[i] == c)
                    resp = true;
            }
            return resp;
        }

        public static Boolean IsVogais(String texto)
        {
            Boolean resp = true;

            for (int i = 0; i < texto.Length; i++)
            {
                if (!(IsVogal(texto[i])))
                    resp = false;
            }
            return resp;
        }

        public static Boolean IsConsoantes(String texto)
        {
            Boolean resp = true;
            for (int i = 0; i < texto.Length; i++)
            {
                if (IsVogal(texto[i]))
                    resp = false;

                if (!Char.IsLetter(texto[i]))
                    resp = false;
            }
            return resp;
        }

        public static Boolean IsInteiro(String texto)
        {
            int inteiro;
            if (int.TryParse(texto, out inteiro))
                return true;

            return false;
        }

        public static Boolean IsReal(String word)
        {
            Boolean resp = false;
            int countDot = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= '0' && word[i] <= '9')
                {
                    resp = true;
                }else if ((word[i]=='.' || word[i]==',') && countDot==0){
                    countDot++;
                }else{
                    resp = false;
                    i = word.Length;
                }
            }
            return resp;
        }

        static void Main(string[] args)
        {
            String texto = "";           
            texto = Console.ReadLine();
            
            while (texto != "FIM")
            {
                if (IsVogais(texto))
                    Console.Write("SIM ");
                else
                    Console.Write("NAO ");

                if (IsConsoantes(texto))
                    Console.Write("SIM ");
                else
                    Console.Write("NAO ");

                if (IsInteiro(texto))
                    Console.Write("SIM ");
                else
                    Console.Write("NAO ");

                if (IsReal(texto))
                    Console.Write("SIM\n");
                else
                    Console.Write("NAO\n");

                texto = System.Console.ReadLine();
            }
        }
    }
}