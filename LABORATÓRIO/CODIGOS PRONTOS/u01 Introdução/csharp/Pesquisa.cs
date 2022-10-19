using System;
class Pesquisa {
   public static bool PesqSeq(int[] vet, int x){
      bool resp = false;
      int n = vet.Length;

      for(int i = 0; i < n; i++){
         if(vet[i] == x){
            resp = true;
            i = n;
         }
      }
      return resp;
   }

   public static bool PesqBin(int[] vet, int x){
      bool resp = false;
      int dir = (vet.Length - 1), esq = 0, meio;

      while (esq <= dir){
         meio = (esq + dir) / 2;
         if(x == vet[meio]){
            resp = true;
            esq = dir + 1;
         } else if (x > vet[meio]) {
            esq = meio + 1;
         } else {
            dir = meio - 1;
         }
      }
      return resp;
   }

   public static bool PesqBinRec(int[] vet, int x){
      return PesqBinRec(vet, x, 0, (vet.Length - 1));
   }

   public static bool PesqBinRec(int[] vet, int x, int esq, int dir){
      bool resp;
      int meio = (esq + dir) / 2;

      if(esq > dir) {
         resp = false;
      } else if(x == vet[meio]){
         resp = true;
      } else if (x > vet[meio]) {
         resp = PesqBinRec(vet, x, meio + 1, dir);
      } else {
         resp = PesqBinRec(vet, x, esq, meio - 1);
      }
      return resp;
   }

   public static void Main (String[] args){
      int[] vet = {2, 3, 5, 7, 9, 11, 15, 17, 20, 21, 30, 43, 49, 70, 71, 82};
      int x = 9;

      Console.WriteLine("Pesquisa Sequencial: " + PesqSeq(vet, x));
      Console.WriteLine("Pesquisa Binária: " + PesqBin(vet, x));
      Console.WriteLine("Pesquisa Binária Recursiva: " + PesqBinRec(vet, x));
   }
}
