using System;

namespace TP02Q01
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

        void ler(String linha){
            String[] linhaSub = linha.Split(',');
            String[] data = linhaSub[3].Split('/');
            this.nome = linhaSub[1];
            this.foto = linhaSub[2];
            this.nascimento = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]));
            this.id = int.Parse(linhaSub[5]);
            
            this.times = new int[linhaSub.Length-6];
            for (int i = 6, j=0; i < linhaSub.Length; i++, j++)
            {
                this.times[j] = int.Parse(linhaSub[i].Replace("[","").Replace("]","").Replace("\"",""));
            }
        }
        static void Main(string[] args)
        {
            Jogadores jogador = new Jogadores();
            String linha = Console.ReadLine();
            while (linha != "FIM")
            {
                jogador.ler(linha);
                jogador.imprimir();
                linha = Console.ReadLine();
            }
        }
    }
}

