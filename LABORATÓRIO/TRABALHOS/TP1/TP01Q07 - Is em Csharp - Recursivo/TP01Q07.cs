using System;
using System.IO;

namespace TP01
{
    class Q03
    {

        public static String isVogalRecursive(String word, int i)
        {
            Boolean resp = false;
            while (i < word.Length)
            {
                if (word[i] == 'a' || word[i] == 'A' ||
                    word[i] == 'e' || word[i] == 'E' ||
                    word[i] == 'i' || word[i] == 'I' ||
                    word[i] == 'o' || word[i] == 'O' ||
                    word[i] == 'u' || word[i] == 'U'){
                    isVogalRecursive(word, ++i);
                    resp = true;
                }
                else{
                    resp = false;
                    i = word.Length;
                }
            }
            return resp?"SIM":"NAO";
        }
        public static String isConsoanteRecursive(String word, int i)
        {
            Boolean resp = false;
            while (i < word.Length)
            {
                if (word[i] != 'a' && word[i] == 'A' &&
                    word[i] != 'e' && word[i] == 'E' &&
                    word[i] != 'i' && word[i] == 'I' &&
                    word[i] != 'o' && word[i] == 'O' &&
                    word[i] != 'u' && word[i] == 'U'){
                    isConsoanteRecursive(word, ++i);
                    resp = true;
                }
                else{
                    resp = false;
                    i = word.Length;
                }
            }
            return resp?"SIM":"NAO";
        }
        public static String isNumberRecursive(String word, int i)
        {
            Boolean resp = false;
            while (i < word.Length)
            {
                if (word[i] >= '0' && word[i] <= '9'){
                    isNumberRecursive(word, ++i);
                    resp = true;
                }
                else{
                    resp = false;
                    i = word.Length;
                }
            }
            return resp?"SIM":"NAO";
        }
        public static String isDoubleRecursive(String word, int i)
        {
            Boolean resp = false;
            int countDot = 0;
            while (i < word.Length)
            {
                if (word[i] >= '0' && word[i] <= '9'){
                    isDoubleRecursive(word, ++i);
                    resp = true;
                }else if ((word[i]=='.' || word[i]==',') && countDot==0){
                    isDoubleRecursive(word, ++i);
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
                    System.Console.WriteLine(isVogalRecursive(linha, 0)+" "+isConsoanteRecursive(linha, 0)+" "+isNumberRecursive(linha, 0)+" "+isDoubleRecursive(linha, 0));
                    
            }
        }
    }
}