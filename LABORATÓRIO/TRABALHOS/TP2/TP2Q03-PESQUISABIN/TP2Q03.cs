using System;

namespace TP02Q03
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

        static String pesquisaSequencial(Jogadores[] jogadores, String nome, int j)
        {
            Boolean resp = false;
            int n = jogadores.Length - j;

            for (int i = 0; i < n; i++)
            {
                if (jogadores[i].nome.Equals(nome))
                {
                    resp = true;
                    i = n;
                }
            }
            return resp ? "SIM" : "NAO";
        }

        public static String PesqBin(Jogadores[] jogadores, String nome, int j)
        {
            bool resp = false;
            int dir = (jogadores.Length - 1)-j, esq = 0, meio;
            int nomeInt = int.Parse(""+nome);
            int nomeIntMeio;

            while (esq <= dir)
            {
                meio = (esq + dir) / 2;
                nomeIntMeio = int.Parse(""+jogadores[meio].nome);
                if (nome == jogadores[meio].nome)
                {
                    resp = true;
                    esq = dir + 1;
                }
                else if (nomeInt > nomeIntMeio)
                {
                    esq = meio + 1;
                }
                else
                {
                    dir = meio - 1;
                }
            }
            return resp ? "SIM" : "NAO";
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

            linha = Console.ReadLine();
            while (linha != "FIM")
            {
                Console.WriteLine(PesqBin(jogador, linha, i));
                linha = Console.ReadLine();
            }
        }
    }
}

