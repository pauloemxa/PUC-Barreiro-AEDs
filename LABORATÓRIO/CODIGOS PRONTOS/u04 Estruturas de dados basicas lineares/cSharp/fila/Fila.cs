using System;

class Fila {
   private int[] array;
   private int primeiro; // Remove do indice "primeiro".
   private int ultimo; // Insere no indice "ultimo".


   /**
    * Construtor da classe.
    */
   


   /**
    * Construtor da classe.
    * @param tamanho Tamanho da fila.
    */
   public Fila (int tamanho){
      array = new int[tamanho+1];
      primeiro = ultimo = 0;
   }


   /**
    * Insere um elemento na ultima posicao da fila.
    * @param x int elemento a ser inserido.
    * @throws Exception Se a fila estiver cheia.
    */
   public void inserir(int x){

      //validar insercao
      if (((ultimo + 1) % array.Length) == primeiro) {
         throw new InvalidOperationException("Erro");
      }

      array[ultimo] = x;
      ultimo = (ultimo + 1) % array.Length;
   }


   /**
    * Remove um elemento da primeira posicao da fila e movimenta 
    * os demais elementos para o primeiro da mesma.
    * @return resp int elemento a ser removido.
    * @throws Exception Se a fila estiver vazia.
    */
   public int remover() {

      //validar remocao
      if (primeiro == ultimo) {
         throw new InvalidOperationException("Erro");
      }

      int resp = array[primeiro];
      primeiro = (primeiro + 1) % array.Length;
      return resp;
   }


   /**
    * Mostra os array separados por espacos.
    */
   public void mostrar (){
      Console.Write("[ ");

      for(int i = primeiro; i != ultimo; i = ((i + 1) % array.Length)) {
         Console.Write(array[i] + " ");
      }

      Console.WriteLine("]");
   }

   public void mostrarRec(){
      Console.Write("[ ");
      mostrarRec(primeiro);
      Console.WriteLine("]");
   }

   public void mostrarRec(int i){
      if(i != ultimo){
         Console.Write(array[i] + " ");
         mostrarRec((i + 1) % array.Length);
      }
   }


   /**
    * Retorna um boolean indicando se a fila esta vazia
    * @return boolean indicando se a fila esta vazia
    */
   public bool isVazia() {
      return (primeiro == ultimo); 
   }
}