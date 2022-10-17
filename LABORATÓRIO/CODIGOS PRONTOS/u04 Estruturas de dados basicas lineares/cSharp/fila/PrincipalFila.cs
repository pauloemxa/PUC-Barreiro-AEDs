using System;

class PrincipalFila {
   public static void Main(String[] args){
      Console.WriteLine("==== FILA ESTATICA ====");
      Fila fila = new Fila(6);
      int x1, x2, x3;

      fila.inserir(5);
      fila.inserir(7);
      fila.inserir(8);
      fila.inserir(9);

      Console.WriteLine("Apos insercoes(5, 7, 8, 9): ");
      fila.mostrar();

      x1 = fila.remover();
      x2 = fila.remover();

      Console.WriteLine("Apos remocoes (" + x1 + ", " + x2 + "):");
      fila.mostrar();

      fila.inserir(3);
      fila.inserir(4);


      Console.WriteLine("Apos insercoes(3, 4): ");
      fila.mostrar();

      x1 = fila.remover();
      x2 = fila.remover();
      x3 = fila.remover();

      Console.WriteLine("Apos remocoes (" + x1 + ", " + x2 + ", " + x3 + "):");
      fila.mostrar();

      fila.inserir(4);
      fila.inserir(5);

      Console.WriteLine("Apos insercoes(4, 5): ");
      fila.mostrar();

      x1 = fila.remover();
      x2 = fila.remover();

      Console.WriteLine("Apos remocoes (" + x1 + ", " + x2 + "):");
      fila.mostrar();

      fila.inserir(6);
      fila.inserir(7);

      Console.WriteLine("Apos insercoes(6, 7): ");
      fila.mostrar();

      x1 = fila.remover();

      Console.WriteLine("Apos remocao (" + x1 + "): ");
      fila.mostrar();
   }
}
