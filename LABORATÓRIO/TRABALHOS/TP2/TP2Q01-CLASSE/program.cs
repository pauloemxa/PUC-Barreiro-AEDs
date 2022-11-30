using System;

namespace TP2Q01_CLASSE
{
    class Jogadores
    {
        private String nome, foto;
        private DateTime nascimento;
        private int id;
        private int[] times;

        public Jogadores()
        {
            this.id = 0;
            this.nome = "";
            this.foto = "";
            this.nascimento = new DateTime(1996, 4, 14);
            this.times = new int[]{ 1, 2, 3, 4 };
        }

        void imprimir()
        {

            Console.Write(this.id + " ");
            Console.Write(this.nome + " ");
            Console.Write(this.nascimento.ToString("d/MM/yyyy") + " ");
            Console.Write(this.foto + " ");

            Console.Write("(");
            for (int i = 0; i < times.Length; i++)
            {
                Console.Write(this.times[i]);
                if (i < this.times.Length - 1 ){

                    Console.Write(", ");
                }
            }
            Console.Write(")");
            Console.WriteLine();

        }

        void ler(String linha)
        {
            String[] linhaSub = linha.Split(',');
            String[] data = linhaSub[3].Split('/'); 
            this.nascimento = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0])); 
            this.nome = linhaSub[1];
            this.foto = linhaSub[2];
            this.times = new int[linhaSub.Length - 6];

            this.id = int.Parse(linhaSub[5]);
            for (int i = 6, j = 0; i < linhaSub.Length; i++, j++)
            {

                this.times[j] = int.Parse(linhaSub[i].Replace("[", "").Replace("]", "").Replace("\"", ""));   /* replace: substituir o colchete por nada */

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

