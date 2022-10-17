/**
 * Algoritmo de ordenacao Heapsort
 * @author Max do Val Machado
 * @version 3 08/2020
 */
 using System;

class Heapsort : Geracao {

   /**
    * Construtor.
    */
   public Heapsort(): base(){
      
   }


   /**
    * Construtor.
    * @param int tamanho do array de numeros inteiros.
    */
   public Heapsort(int tamanho) : base(tamanho){
      
   }


   /**
    * Algoritmo de ordenacao Heapsort.
    */
  
   public override void Sort() {
      //Alterar o vetor ignorando a posicao zero
      int[] tmp = new int[n+1];
      for(int i = 0; i < n; i++){
         tmp[i+1] = array[i];
      }
      array = tmp;

      //Contrucao do heap
      for(int tamHeap = 2; tamHeap <= n; tamHeap++){
         Construir(tamHeap);
      }

      //Ordenacao propriamente dita
      int tamanhoHeap = n;
      while(tamanhoHeap > 1){
         Swap(1, tamanhoHeap--);
         Reconstruir(tamanhoHeap);
      }

      //Alterar o vetor para voltar a posicao zero
      tmp = array;
      array = new int[n];
      for(int i = 0; i < n; i++){
         array[i] = tmp[i+1];
      }
   }


   public void Construir(int tamHeap){
      for(int i = tamHeap; i > 1 && array[i] > array[i/2]; i /= 2){
         Swap(i, i/2);
      }
   }


   public void Reconstruir(int tamHeap){
      int i = 1;
      while(i <= (tamHeap/2)){
         int filho = GetMaiorFilho(i, tamHeap);
         if(array[i] < array[filho]){
            Swap(i, filho);
            i = filho;
         }else{
            i = tamHeap;
         }
      }
   }

   public int GetMaiorFilho(int i, int tamHeap){
      int filho;
      if (2*i == tamHeap || array[2*i] > array[2*i+1]){
         filho = 2*i;
      } else {
         filho = 2*i + 1;
      }
      return filho;
   }
}
