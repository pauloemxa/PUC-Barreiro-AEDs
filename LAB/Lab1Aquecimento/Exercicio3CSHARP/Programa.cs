using System;
class Programa{
    
    
    public static void Main(string[] args){
       Random gerador = new Random();
        int[] vetor = new int[10];
        int total = 0;
        for(int i=0;i<vetor.Length; i++){
            vetor[i] = gerador.Next(100);
            total+=vetor[i];
            Console.Write(" "+vetor[i]);
        }
        double media = (double)total/vetor.Length;
        Console.WriteLine("Media dos valores: "+media);
        Console.WriteLine("Valores acima da média: ");
        foreach(int i in vetor){
            if(i>=media){
                Console.WriteLine(i);
            }
        }
    }
}