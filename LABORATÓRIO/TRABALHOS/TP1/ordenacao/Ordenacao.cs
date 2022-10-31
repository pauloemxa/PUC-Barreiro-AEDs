using System;

namespace TP01
{
    class Q01 {        

        public static Boolean pesquisaSequencial(String word, Char valorProcurado){
            Boolean resp = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == valorProcurado)
                {
                    resp = true;
                    i = word.Length;
                }
            }
            return resp;
        }
        public static Boolean pesquisaBinaria(String word, int valorProcurado){
            Boolean resp = false;
            int dir = word.Length-1, esq = 0, meio;

            while (esq <= dir)
            {
                meio = (esq+dir) / 2;
                if(valorProcurado == word[meio]){
                    resp = true;
                    esq = word.Length-1;
                }else if(valorProcurado > word[meio]){
                    esq = meio + 1;
                }else{
                    dir = meio -1;
                }
            }
            return resp;
        }

        public static String orSelecao(String word){
            String resp = false;
            for (int i = 0; i < word.length; i++)
            {
                int menor = word.Length;
                for (int j = (i+1); j < word.Length; j++)
                {
                    menor = j;
                }
            }
            swap(menor, i);
          
            return resp;
        }


        static void Main(string[] args)
        {
            String linha = Console.ReadLine();
        
            while (linha != "FIM"){
                Console.WriteLine(pesquisaBinaria(linha, 2));
                linha = Console.ReadLine();
            }
        }
    }
}