/**
 * Algoritmo de ordenacao por insercao
 * @author Max do Val Machado
 * @version 3 01/2020
 */
using System;
class Insercao : Geracao {

	/**
	 * Construtor.
	 */
   public Insercao() : base(){
      
   }


	/**
	 * Construtor.
	 * @param int tamanho do array de numeros inteiros.
	 */
   public Insercao(int tamanho) : base(tamanho){
      
   }


	/**
	 * Algoritmo de ordenacao por insercao.
	 */
   
   public override void Sort() {
		for (int i = 1; i < n; i++) {
			int tmp = array[i];
         int j = i - 1;

         while ((j >= 0) && (array[j] > tmp)) {
            array[j + 1] = array[j];
            j--;
         }
         array[j + 1] = tmp;
      }
	}
}
