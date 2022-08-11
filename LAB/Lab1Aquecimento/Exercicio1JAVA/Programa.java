import java.util.Scanner;
class Programa{
    
    static double calculaVolume(double raio){
        double volume = 4*Math.PI*Math.pow(raio,3)/3;
        return volume;
    }
    public static void main(String[] args){
        Scanner entrada = new Scanner(System.in);
        System.out.println("Digite o valor do raio: ");
        double valor = entrada.nextDouble();
        System.out.println("O volume é: "+calculaVolume(valor));
    }
}