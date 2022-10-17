using System;

class PrincipalLista {
   public static void Main(String[] args) {
      Console.WriteLine("==== LISTA ESTATICA ====");
      Lista lista = new Lista(6);
      int x1, x2, x3;

      lista.inserirInicio(1);
      lista.inserirInicio(0);
      lista.inserirFim(2);
      lista.inserirFim(3);
      lista.inserir(4, 3);
      lista.inserir(5, 2);

      Console.Write("Apos insercoes: ");
      lista.mostrar();

      x1 = lista.removerInicio();
      x2 = lista.removerFim();
      x3 = lista.remover(2);

      Console.Write("Apos remocoes (" + x1 + ", " + x2 + ", " + x3 + "):");
      lista.mostrar();
   }
}
