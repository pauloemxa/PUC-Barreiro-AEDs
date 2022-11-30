using System;

namespace TP01
{
    class RevisaoQ01 {      

        public static String imprimeNomeCorreto(String linha1, String linha2){
            String resp = "";
            for (int i = 0; i < linha1.Length; i+=2)
            {
                    if (i < linha1.Length - 1)
                    {
                        resp += linha1[i];
                        resp += linha1[i+1];
                        if (linha2.Length%2==0)
                        {
                            resp += linha2[i];
                            resp += linha2[i+1];
                        }else{
                            resp += linha2[i];
                            if (i<linha2.Length - 2)
                            {
                                resp += linha2[i+1];
                            }
                        }
                    
                    }
            }
            return resp;
        }  

        static void Main(string[] args)
        {
            String quantidade = Console.ReadLine();
            String linha1 = "", linha2 = "";

            for (int i = 0; i < int.Parse(quantidade); i++)
            {
                linha1 = Console.ReadLine();                
                linha2 = Console.ReadLine();
                Console.WriteLine(imprimeNomeCorreto(linha1, linha2));                
            }
        }
    }
}

