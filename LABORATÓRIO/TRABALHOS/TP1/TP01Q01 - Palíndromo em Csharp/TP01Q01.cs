using System;

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
             
               i    j
     linha = asdfggfksa



            return resp?"SIM":"NAO";
        }

        static void Main(string[] args)
        {
            String linha = Console.ReadLine();
        
            while(linha != "FIM")
            {
                Console.WriteLine(linha);
                linha = Console.ReadLine();
            }
        }
    }
}

