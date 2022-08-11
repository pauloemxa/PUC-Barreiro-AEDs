using System;
class Programa{
    
    static double CalculaVolume(ref double raio){
        raio = Convert.ToInt32(raio);
        double volume = 4*Math.PI*Math.Pow(raio,3)/3;
        return volume;
    }
    public static void Main(string[] args){
        Console.WriteLine("Digite o valor do raio: ");
        Double.TryParse(Console.ReadLine(),out double valor);
        Console.WriteLine("O volume é: "+CalculaVolume(ref valor));
        Console.WriteLine("O raio digitado é: "+valor);
    }
}