using System;
using System.IO;

namespace TP01
{
<<<<<<< HEAD
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
=======
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
>>>>>>> 298a171788e3588f15b18db3fc4158dd7080747b
        }

        static void Main(string[] args)
        {
            String linha = "";
            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
<<<<<<< HEAD
                    System.Console.WriteLine( (isVogalRecursive(linha, 0, false)?"SIM":"NAO")+" "+
                                              (isConsoanteRecursive(linha, 0, false)?"SIM":"NAO")+" "+
                                              (isNumberRecursive(linha, 0, false)?"SIM":"NAO")+" "+
                                              (isDoubleRecursive(linha, 0, 0, false)?"SIM":"NAO"));    
=======
                    System.Console.WriteLine(isVogalRecursive(linha, 0)+" "+isConsoanteRecursive(linha, 0)+" "+isNumberRecursive(linha, 0)+" "+isDoubleRecursive(linha, 0));
                    
>>>>>>> 298a171788e3588f15b18db3fc4158dd7080747b
            }
        }
    }
}