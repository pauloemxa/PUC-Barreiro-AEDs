using System;

namespace TP02Q02
{
    class Jogadores {
        private String nome;
        private String foto;
        private DateTime nascimento;
        private int id;
        private int[] times;

        public Jogadores(){
            this.nome = "";
            this.foto = "";
            this.nascimento = new DateTime(1111, 1, 1);
            this.id = 0;
            this.times = new int[]{123,123,456,789};
        }    
        void imprimir(){
            Console.Write(this.id+" ");
            Console.Write(this.nome+" ");
            Console.Write(this.nascimento.ToString("d/MM/yyyy")+" ");
            // Console.Write(this.nascimento.ToShortDateString()+" ");
            Console.Write(this.foto+" ");
            
            Console.Write("(");
            for (int i = 0; i < this.times.Length; i++)
            {
                Console.Write(this.times[i]);
                if (i < this.times.Length-1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(")");
            Console.WriteLine();
        }

        static String pesquisaSequencial(Jogadores[] jogador, String nome){
            Boolean resp = false;
            int n = jogador.Length;

            for(int i = 0; i < n; i++){
                if(jogador[i].nome == nome){
                    resp = true;
                    i = n;
                }
            }
            return resp?"SIM":"NAO";
        }

        void ler(String linha){
            String[] linhaSub = linha.Split(',');
            String[] id = linhaSub[5].Split('/');
            String[] data = linhaSub[3].Split('/');
            this.nome = linhaSub[1];
            this.foto = linhaSub[2];
            this.nascimento = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]));
            this.id = int.Parse(id[0]);
            
            this.times = new int[linhaSub.Length-6];
            for (int i = 6, j=0; i < linhaSub.Length; i++, j++)
            {
                this.times[j] = int.Parse(linhaSub[i].Replace("[","").Replace("]","").Replace("\"",""));
            }
        }
        static void Main(string[] args)
        {
            Jogadores[] jogador = new Jogadores[15];
            int i = 0;
            String linha = Console.ReadLine();
            while (linha != "FIM")
            {
                jogador[i] = new Jogadores();
                jogador[i].ler(linha);
                linha = Console.ReadLine();
                i++;
            }
            linha = Console.ReadLine();
            while (linha != "FIM")
            {
                Console.WriteLine(pesquisaSequencial(jogador,linha));
                linha = Console.ReadLine();
            }
        }
    }
}

