using System;
using System.Collections;

namespace TP02Q09
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
        public void imprimir()
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
        static void Main(string[] args)
        {
            String linha = Console.ReadLine();
            
            int i = 0, tamComandos = 0, filaTam = 0;

            Queue time = new Queue(filaTam);
            Jogadores jogador = new Jogadores();

            while (linha != "FIM")
            {
                jogador = new Jogadores();
                jogador.ler(linha);
                time.Enqueue(jogador);
                linha = Console.ReadLine();
                i++;
                filaTam++;
            }
            tamComandos = int.Parse(Console.ReadLine());

            linha = Console.ReadLine();

            String[] comando = {};

            for (i = 0; i < tamComandos; i++)
            {
                comando = linha.Split(',');
                comando = comando[0].Split(' ');
                jogador = new Jogadores();
                switch (comando[0])
                {
                    case "I":
                        if (filaTam == 5)
                        {
                            time.Dequeue();
                            jogador.ler(linha.Substring(2));
                            time.Enqueue(jogador);
                        }else{
                            jogador.ler(linha.Substring(2));
                            time.Enqueue(jogador);
                            filaTam++;
                        }
                        break;
                    case "R":
                        time.Dequeue();
                        filaTam--;
                        break;
                    default:
                        break;
                }
                linha = Console.ReadLine();
            }


            Jogadores jogadorImprimir = new Jogadores();
            foreach (var item in time)
            {
                jogadorImprimir = (Jogadores)item;
                jogadorImprimir.imprimir();
            }
        }
    }
}