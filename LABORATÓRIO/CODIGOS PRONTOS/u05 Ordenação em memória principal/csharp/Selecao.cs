/**
 * Algoritmo de ordenacao Heapsort
 * @author Max do Val Machado
 * @version 3 08/2020
 */
using System;

class Selecao : Geracao {

   /**
    * Construtor.
    */
   public Selecao() : base(){
      
   }


   /**
    * Construtor.
    * @param int tamanho do array de numeros inteiros.
    */
   public Selecao(int tamanho) : base(tamanho){
      
   }


   /**
    * Algoritmo de ordenacao por selecao.
    */
   
   public override void Sort() {
      for (int i = 0; i < (n - 1); i++) {
         int menor = i;
         for (int j = (i + 1); j < n; j++){
            if (array[menor] > array[j]){
               menor = j;
            }
         }
         Swap(menor, i);
      }
   }
}
