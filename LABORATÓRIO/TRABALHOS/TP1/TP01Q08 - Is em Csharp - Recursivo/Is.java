public class Is{

   //Letra Vogal Maiuscula
   public static boolean vogalMaiuscula(char a){
      boolean valido = false;
      if(a==65 || a==69 || a==73|| a==79|| a==85){
         valido = true;
      }
      return valido;
   }
   
   //letra Vogal Minuscula
   public static boolean vogalMinuscula(char a){
      boolean valido = false;
      if(a==97 || a==101 || a==105|| a==111|| a==117){
         valido = true;
      }
      return valido;
   }
   
   //Letra
   public static boolean isLetra(char a){
      boolean valido = true;
      if((a>=65 && a<=90)==false && (a>=97 && a<=122)==false && (a==32)==false){
         valido = false;
      }
     
      return valido;
   }
 
      //Palavra Vogal 
   public static boolean vogais(String a){
      boolean valido = false;
      for(int i=0; i<a.length(); i++){
         if(vogalMaiuscula(a.charAt(i))== true || vogalMinuscula(a.charAt(i)) == true){
            valido = true;                 
         }
         else if(a.charAt(i) == 32){
            valido = true;
         }
         else{
            valido = false;
            i = a.length();
         }
      }
   
      return valido;
   }
   
      //Palavra consoante
   public static boolean consoantes(String a){
      boolean valido = false;
      for(int i=0; i<a.length(); i++){
         if(vogalMaiuscula(a.charAt(i))== true || vogalMinuscula(a.charAt(i)) == true){
            valido = false;                          
            i = a.length();
         }
         else{
            if(isLetra(a.charAt(i))==true){
               valido = true;
            }
            else{
               valido = false;
               i = a.length();
            }   
         }
      }
   
      return valido;
   }
 
   //Numero Inteiro
   public static boolean inteiro(String a){
      boolean valido = true;
      for(int i=0; i<a.length(); i++){
         if(a.charAt(i) >= 48 && a.charAt(i) <= 57 || a.charAt(i) == 44 || a.charAt(i) == 46){
            if(a.charAt(i) == ',' || a.charAt(i) == '.'){
               valido = false;
            }
         }
         else{
            valido = false;
            i = a.length(); 
         }
      }
      return valido;  
   }   
   
   //Numero Real
   public static boolean real(String a){
      boolean valido = false;
      int x=0;
      for(int i=0; i<a.length(); i++){
         if(a.charAt(i) >= 48 && a.charAt(i) <= 57 || a.charAt(i) == 44 || a.charAt(i) == 46){
            valido = true;
            if(a.charAt(i) == 44 || a.charAt(i) == 46){
               x++;
            }
            if(x>1){
               valido = false;
               i = a.length();
            } 
         }
         else{
            valido = false;
            i = a.length();
         }
      }
      return valido;  
   }   
      
    //metodo equals
   public static boolean equals(String a, String b){
      boolean resp = true;  
        
      if(a.length() != 3){
         resp = false;
      }
      else{
         for(int i=0;i<a.length();i++){
            if(a.charAt(i) != b.charAt(i)){
               i = a.length();
               resp = false;
            }
         }        
      }
        
      return resp;
   }
   
      
   /////////////////////////////////////////////////////////////////////////////////////////////
 
   public static void main(String[] args){
      //definindo dados
      boolean valido = false;
      String b = "FIM";
          
      do{
      //obtendo dados
         String a = MyIO.readLine();
      
         if(equals(a,b)){
            valido = true;
         }
         else{
          //mostrar resultado
            if(vogais(a) == true){
               MyIO.print("SIM");
            }
            else{
               MyIO.print("NAO");
            }
         
            if(consoantes(a) == true){
               MyIO.print(" SIM");
            }
            else{
               MyIO.print(" NAO");
            }
         
            if(inteiro(a) == true){
               MyIO.print(" SIM");
            }
            else{
               MyIO.print(" NAO");
            }
         
            if(real(a) == true){
               MyIO.println(" SIM");
            }
            else{
               MyIO.println(" NAO");
            }
         
         }
      
      }while(valido == false);
   
   }//fim main
}//fim class
