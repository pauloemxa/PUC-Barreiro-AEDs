/**
 * Algoritmo de ordenacao Quicksort
 * @author Max do Val Machado
 * @version 3 08/2020
 */
 using System;
class Quicksort : Geracao {

	/**
	 * Construtor.
	 */
   public Quicksort() : base(){
      
   }


	/**
	 * Construtor.
	 * @param int tamanho do array de numeros inteiros.
	 */
   public Quicksort(int tamanho) : base(tamanho){
      
   }


	/**
	 * Algoritmo de ordenacao Quicksort.
	 */
  
   public override void Sort() {
      SortQuicksort(0, n-1);
   }

	/**
	 * Algoritmo de ordenacao Quicksort.
    * @param int esq inicio do array a ser ordenado
    * @param int dir fim do array a ser ordenado
	 */
    private void SortQuicksort(int esq, int dir) {
        int i = esq, j = dir;
        int pivo = array[(dir+esq)/2];
        while (i <= j) {
            while (array[i] < pivo) i++;
            while (array[j] > pivo) j--;
            if (i <= j) {
                Swap(i, j);
                i++;
                j--;
            }
        }
        if (esq < j)  SortQuicksort(esq, j);
        if (i < dir)  SortQuicksort(i, dir);
    }
}
