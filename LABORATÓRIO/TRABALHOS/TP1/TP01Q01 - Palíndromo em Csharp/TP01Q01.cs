using System;
using System.IO;

namespace TP01
{
    class Q01 {        

        public static String isPalindromo(String word){
            Boolean resp = false;
            for (int i = 0, j=word.Length-1; i <= j-1; i++, j--)
            {
                if (word[i]==word[j])
                {
                    resp = true;
                }else{
                    resp = false;
                    i=j;
                }
            }
            return resp?"SIM":"NAO";
        }

        static void Main(string[] args)
        {
            String linha = "";
        
            while (linha != "FIM"){
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(isPalindromo(linha));
            }
        }
    }
}