using System;

namespace TP04Q01
{
    class Celula
    {
        public Jogadores elemento;
        public Celula prox;

        public Celula(){

        }

        public Celula(Jogadores jogador)
        {
            this.elemento = jogador;
            this.prox = null;
        }
    }

    class Lista
    {
        private Celula primeiro;
        private Celula ultimo;

        public Lista()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }

        public void inserirInicio(Jogadores jogador)
        {
            Celula tmp = new Celula(jogador);
            tmp.prox = primeiro.prox;
            primeiro.prox = tmp;
            if (primeiro == ultimo)
            {
                ultimo = tmp;
            }
            tmp = null;
        }
        public void inserirFim(Jogadores jogador)
        {
            ultimo.prox = new Celula(jogador);
            ultimo = ultimo.prox;
        }
        public Jogadores removerInicio()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro ao remover (vazia)!");
            }
            Celula tmp = primeiro;
            primeiro = primeiro.prox;
            Jogadores resp = primeiro.elemento;
            tmp.prox = null;
            tmp = null;
            return resp;
        }
        public Jogadores removerFim()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro ao remover (vazia)!");
            }
            // Caminhar ate a penultima celula:
            Celula i;
            Jogadores resp = ultimo.elemento;//tava dentro do for
            for (i = primeiro; i.prox != ultimo; i = i.prox)
            {
                
                ultimo = i;
                i = ultimo.prox = null;
            }
            return resp;
        }
        public void mostrar()
        {
            Console.Write("[ ");
            for (Celula i = primeiro.prox; i != null; i = i.prox)
            {
                Console.Write(i.elemento.imprimir() + " ");
            }
            Console.Write("] ");
        }
    }

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

            Jogadores jogadores = new Jogadores();
            Lista lista = new Lista();
            while (linha != "FIM")
            {
                jogadores.ler(linha);
                lista.inserirFim(jogadores);
                linha = Console.ReadLine();
            }
            lista.mostrar();


        }
    }
}
