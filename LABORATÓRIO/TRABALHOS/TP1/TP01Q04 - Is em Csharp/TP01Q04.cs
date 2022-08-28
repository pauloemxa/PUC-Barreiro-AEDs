using System;
using System.IO;

namespace TP01
{
    class Q03
    {
        public static String isVogal(String word)
        {
            Boolean resp = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (
                word[i] == 'a' || word[i] == 'A' ||
                word[i] == 'e' || word[i] == 'E' ||
                word[i] == 'i' || word[i] == 'I' ||
                word[i] == 'o' || word[i] == 'O' ||
                word[i] == 'u' || word[i] == 'U')
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                    i = word.Length;
                }
            }
            return resp?"SIM":"NAO";
        }
        public static String isConsoante(String word)
        {
            Boolean resp = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (
                word[i] != 'a' && word[i] == 'A' &&
                word[i] != 'e' && word[i] == 'E' &&
                word[i] != 'i' && word[i] == 'I' &&
                word[i] != 'o' && word[i] == 'O' &&
                word[i] != 'u' && word[i] == 'U')
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                    i = word.Length;
                }
            }
            return resp?"SIM":"NAO";
        }
        public static String isNumber(String word)
        {
            Boolean resp = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= '0' && word[i] <= '9')
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                    i = word.Length;
                }
            }
            return resp?"SIM":"NAO";
        }
        public static String isDouble(String word)
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
            return resp?"SIM":"NAO";
        }

        static void Main(string[] args)
        {
            String linha = "";
            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(isVogal(linha)+" "+isConsoante(linha)+" "+isNumber(linha)+" "+isDouble(linha));
            }
        }
    }
}