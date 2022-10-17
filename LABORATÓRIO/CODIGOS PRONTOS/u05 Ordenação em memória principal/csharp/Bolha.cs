/**
 * Algoritmo de ordenacao Heapsort
 * @author Max do Val Machado
 * @version 3 08/2020
 */
using System;

class Bolha : Geracao {

	/**
	 * Construtor.
	 */
   public Bolha() : base(){
      
   }


	/**
	 * Construtor.
	 * @param int tamanho do array de numeros inteiros.
	 */
   public Bolha(int tamanho) : base(tamanho){
     
   }


	/**
	 * Algoritmo de ordenacao Bolha.
	 */
  
   public override void Sort() {
		for (int i = (n - 1); i > 0; i--) {
			for (int j = 0; j < i; j++) {
				if (array[j] > array[j + 1]) {
                    Swap(j, j+1);
				}
			}
		}
   }
}
