using System;

namespace TP03Q02
{
    class Jogadores
    {
        private String nome;
        private String foto;
        private DateTime nascimento;
        private int id;
        private int[] times;

        public Jogadores()
        {
            this.nome = "";
            this.foto = "";
            this.nascimento = new DateTime(1111, 1, 1);
            this.id = 0;
            this.times = new int[] { 123, 123, 456, 789 };
        }
        void imprimir()
        {
            Console.Write(this.id + " ");
            Console.Write(this.nome + " ");
            Console.Write(this.nascimento.ToString("d/MM/yyyy") + " ");
            Console.Write(this.foto + " ");

            Console.Write("(");
            for (int i = 0; i < this.times.Length; i++)
            {
                Console.Write(this.times[i]);
                if (i < this.times.Length - 1)
                {
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

            this.nome = linhaSub[1];
            this.foto = linhaSub[2];
            this.nascimento = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]));
            this.id = int.Parse(linhaSub[5]);

            this.times = new int[linhaSub.Length - 6];
            for (int i = 6, j = 0; i < linhaSub.Length; i++, j++)
            {
                this.times[j] = int.Parse(linhaSub[i].Replace("[", "").Replace("]", "").Replace("\"", ""));
            }
        }

        public static void Sort(Jogadores[] jogadores, int tamArray)
        {
            for (int i = 1; i < tamArray; i++)
            {
                Jogadores tmp = jogadores[i];
                int j = i - 1;

                while ((j >= 0) && (jogadores[j].id > tmp.id))
                {
                    jogadores[j + 1] = jogadores[j];
                    j--;
                }
                jogadores[j + 1] = tmp;
            }
        }

        public static void insertSort(Jogadores[] jogadores, int tamArray)
        {
            for (int i = 1; i < jogadores.Length - tamArray; i++)
            {
                Jogadores tmp = jogadores[i];
                int j = i - 1;

                while ((j >= 0) && string.Compare(jogadores[j].nome, tmp.nome) == 1)
                {
                    jogadores[j + 1] = jogadores[j];
                    j--;
                }
                jogadores[j + 1] = tmp;
            }
        }

        static void Main(string[] args)
        {
            int i = 0;
            String linha = Console.ReadLine();
            Jogadores[] jogador = new Jogadores[30];
            while (linha != "FIM")
            {
                jogador[i] = new Jogadores();
                jogador[i].ler(linha);
                linha = Console.ReadLine();
                i++;
            }
            Sort(jogador, i);
            for (int j = 0; j < i; j++)
            {
                jogador[j].imprimir();
            }
        }
    }
}

