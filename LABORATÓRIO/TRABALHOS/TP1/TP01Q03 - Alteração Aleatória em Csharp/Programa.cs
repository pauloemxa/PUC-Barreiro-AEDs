using System;
class Programa{

   

   static bool IsFim(string s){
      return (s.Length == 3 && s[0] == 'F' && s[1] == 'I' && s[2] == 'M');
   }

   public static string Altera(string str,char um,char dois) // funçao que pegara 2 numeros aleatorios começando na posiçao 4 da memoria
                                                                // (seed)
    {
        string resp = "";
        for (int i = 0; i < str.Length; i++) {
            
            if (str[i] == um) {
                resp += dois;
            } else{
                resp += str[i];
            }
            
        }
        return resp;
    }
   
    
    public static void Main(string[] args){
      string[] entrada = new string[1000];
      int numEntrada = 0;

      //Leitura da entrada padrao
      do {
         entrada[numEntrada] = Console.ReadLine();
      } while (IsFim(entrada[numEntrada++]) == false);
      numEntrada--;   //Desconsiderar ultima linha contendo a palavra FIM

        Random gerador = new Random(4);
        char aleatorio = (char) ('a' + (Math.Abs(gerador.Next()) % 26));
        char aleatorio2 = (char) ('a' + (Math.Abs(gerador.Next()) % 26));

         Console.WriteLine("valores: "+aleatorio+" e "+aleatorio2);
      //Para cada linha de entrada, gerando uma de saida contendo o numero de letras maiusculas da entrada
      for(int i = 0; i < numEntrada; i++){
         Console.WriteLine(Altera(entrada[i],aleatorio,aleatorio2));
      }
    }
}