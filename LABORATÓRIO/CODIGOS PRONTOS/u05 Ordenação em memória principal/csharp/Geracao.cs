
/**
 * Algoritmo de ordenacao Heapsort
 * @author Max do Val Machado
 * @version 3 08/2020
 */
using System;

class Geracao {
   protected int[] array;
   protected int n;


	/**
	 * Construtor.
	 */
   public Geracao(){
      array = new int[100];
      n = array.Length;
   }


	/**
	 * Construtor.
	 * @param int tamanho do array de numeros inteiros.
	 */
   public Geracao(int tamanho){
      array = new int[tamanho];
      n = array.Length;
   }


	/**
	 * Produz um array ordenado de modo crescente.
	 */
	public void Crescente() {
		for (int i = 0; i < n; i++) {
			array[i] = i;
		}
	}


	/**
	 * Produz um array ordenado de modo decrescente.
	 */
	public void Decrescente() {
		for (int i = 0; i < n; i++) {
			array[i] = n - 1 - i;
		}
	}


	/**
	 * Produz um array com numeros aleatorios.
	 */
	public void Aleatorio() {
		Random rand = new Random();
	   Crescente();	
		for (int i = 0; i < n; i++) {
         Swap(i, Math.Abs(rand.Next()) % n);
		}
	}


	/**
	 * Efetua a leitura dos elementos via entrada padrao.
	 */
	public void EntradaPadrao() {
      n = Convert.ToInt32(Console.ReadLine());
      array = new int[n];

		for (int i = 0; i < n; i++) {
			array[i] = Convert.ToInt32(Console.ReadLine());
		}
	}

	/**
	 * Recebe um Efetua a leitura dos elementos via entrada padrao.
	 */
   public void Entrada(int[] vet){
      n = vet.Length;
      array = new int[n];
      for(int i = 0; i < n; i++){
         array[i] = vet[i];
      }
   }


	/**
	 * Mostra os k primeiros elementos do array.
	 * @param int k indica a quantidade de elementos do array a serem mostrados.
	 */
	public void Mostrar(int k) {
		Console.Write("[");
		
		for (int i = 0; i < k; i++) {
         Console.Write(" ("+i+")" + array[i]);
		}
		
		Console.WriteLine("]");
	}


	/**
	 * Mostra os elementos do array.
	 */
   public void Mostrar() {
      Console.Write("[");

      for (int i = 0; i < n; i++) {
         Console.Write(" ("+i+")" + array[i]);
      }

      Console.WriteLine("]");
   }


   /**
    * Troca o conteudo de duas posicoes do array
    * @param i int primeira posicao
    * @param j int segunda posicao
    */
   public void Swap(int i, int j) {
      int temp = array[i];
      array[i] = array[j];
      array[j] = temp;
   }


   


   /**
    * Retorna verdadeiro/falso indicando se o array esta ordenado
    * @return boolean indicando se o array esta ordenado
    */
   public bool IsOrdenado(){
      bool resp = true;
      for(int i = 1; i < n; i++){
         if(array[i] < array[i-1]){
            i = n;
            resp = false;
         }
      }
      return resp;
   }

   /*
    * Metodo a ser implementado nas subclasses
    */
   public virtual void Sort(){
      Console.WriteLine("Método a ser implementado nas subclasses.");
   }
}
