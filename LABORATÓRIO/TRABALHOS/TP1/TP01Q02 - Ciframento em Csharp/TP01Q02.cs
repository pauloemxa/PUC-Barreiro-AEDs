using System;
using System.IO;

namespace TP01
{
    class Q02 {        

        public static String ciframento(String word){
            String resp = "";
            for (int i = 0; i < word.Length; i++)
            {
                resp += "" + ((char)((int)word[i] + 3));
            }
            return resp;
        }

        static void Main(string[] args)
        {
            String linha = "";
        
            while (linha != "FIM"){
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(ciframento(linha));
            }
        }
    }
}










      i
      asddsa