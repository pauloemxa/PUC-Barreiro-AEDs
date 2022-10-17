/**
 * Algoritmo de ordenacao Heapsort
 * @author Max do Val Machado
 * @version 3 08/2020
 */
using System;
using System.Diagnostics;

class Principal {
	public static void Main(String[] args) {

      //Delcaracao de variaveis
      Geracao algoritmo;
      int n = (args.Length < 1) ? 1000 : Convert.ToInt32(args[0]);
      var stopwatch = new Stopwatch();


      //Inicializacao do algoritmo de ordenacao
      //algoritmo = new Bolha(n);
      //algoritmo = new Countingsort(n);
      //algoritmo = new Heapsort(n);
      //algoritmo = new Insercao(n);
      //algoritmo = new Mergesort(n);
      //algoritmo = new Quicksort(n);
      algoritmo = new Selecao(n);
      //algoritmo = new Shellsort(n);


      //Geracao do conjunto a ser ordenado
		//algoritmo.aleatorio();
		algoritmo.Crescente();
		//algoritmo.decrescente();


      //Mostrar o conjunto a ser ordenado
		//algoritmo.mostrar();
		

      //Execucao do algoritmo de ordenacao
		stopwatch.Start();
		algoritmo.Sort();
		stopwatch.Stop();


      //Mostrar o conjunto ordenado, tempo de execucao e status da ordenacao
		//algoritmo.mostrar();
		Console.WriteLine("Tempo para ordenar: " + stopwatch.Elapsed);
		Console.WriteLine("isOrdenado: " + algoritmo.IsOrdenado());
	}
}
