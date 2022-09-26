using System;
using System.IO;

namespace TP01
{
    class Q07
    {
        public static Boolean isVogal(char c){
            return (c == 'a' ||  c == 'A' ||
                    c == 'e' || c == 'E' ||
                    c == 'i' || c == 'I' ||
                    c == 'o' || c == 'O' ||
                    c == 'u' || c == 'U');
        }
        public static Boolean isNumber(char c){
            return (c >= '0' && c <='9');
        }

        public static Boolean isVogalRecursive(String word, int i, Boolean resp)
        {
            if (i < word.Length)
            {
                if (isVogal(word[i]))
                {
                    resp = true;
                    resp = isVogalRecursive(word, ++i, resp);   
                }
                else{
                    resp = false;
                }
            }
            return resp;
        }

        public static Boolean isConsoanteRecursive(String word, int i, Boolean resp)
        {
            if (i < word.Length)
            {
                if (!(isVogal(word[i])) && !(isNumber(word[i])))
                {
                    resp = true;
                    resp = isConsoanteRecursive(word, ++i, resp);   
                }
                else{
                    resp = false;
                }
            }
            return resp;
        }
        public static Boolean isNumberRecursive(String word, int i, Boolean resp)
        {
            if (i < word.Length)
            {
                if (isNumber(word[i]))
                {
                    resp = true;
                    resp = isNumberRecursive(word, ++i, resp);   
                }
                else{
                    resp = false;
                }
            }
            return resp;
        }
        public static Boolean isDoubleRecursive(String word, int i, int countDot, Boolean resp)
        {
            if (i < word.Length)
            {
                if (isNumber(word[i]))
                {
                    resp = true;
                    resp = isDoubleRecursive(word, ++i, countDot, resp);   
                }else if ((word[i]=='.' || word[i]==',') && countDot==0){
                    resp = isDoubleRecursive(word, ++i, ++countDot, resp);   
                }
                else{
                    resp = false;
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
                    System.Console.WriteLine( (isVogalRecursive(linha, 0, false)?"SIM":"NAO")+" "+
                                              (isConsoanteRecursive(linha, 0, false)?"SIM":"NAO")+" "+
                                              (isNumberRecursive(linha, 0, false)?"SIM":"NAO")+" "+
                                              (isDoubleRecursive(linha, 0, 0, false)?"SIM":"NAO"));    
            }
        }
    }
}