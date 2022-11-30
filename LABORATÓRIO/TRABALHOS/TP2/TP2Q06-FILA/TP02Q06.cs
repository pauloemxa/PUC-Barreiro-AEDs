using System;

namespace TP02Q06
{
    class FilaCircularJogadores
    {
        private Jogadores[] array;
        int primeiro, ultimo;
        // private int n;
        /**
         * Construtor da classe.
         */

        /**
         * Construtor da classe.
         * @param tamanho Tamanho da lista.
         */
        public FilaCircularJogadores(int tamanho)
        {
            array = new Jogadores[tamanho+1];
            primeiro = ultimo = 0;
            // n = 0;
        }

        /**
         * Insere um elemento na ultima posicao da lista.
         * @param x int elemento a ser inserido.
         * @throws Exception Se a lista estiver cheia.
         */
        public void inserir(Jogadores x)
        {
            if (((ultimo + 1) % array.Length) == primeiro)
                remover();
                // throw new Exception("Erro!");
            
            array[ultimo] = x;
            ultimo = (ultimo + 1) % array.Length;
        }


        /**
         * Remove um elemento da ultima posicao da lista.
         * @return resp int elemento a ser removido.
         * @throws Exception Se a lista estiver vazia.
         */
        public Jogadores remover()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");
                
            Jogadores resp = array[primeiro];
            primeiro = (primeiro + 1) % array.Length;
            
            return resp;
        }


        /**
         * Mostra os elementos da lista separados por espacos.
         */
        public void mostrar()
        {
            int i = primeiro;

            while (i!=ultimo)
            {
                array[i].imprimir();
                i=(i+1)%array.Length;
            }
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

            FilaCircularJogadores time = new FilaCircularJogadores(5);
            Jogadores jogador = new Jogadores();

            int i = 0, tamComandos = 0;

            while (linha != "FIM")
            {
                jogador = new Jogadores();
                jogador.ler(linha);
                time.inserir(jogador);
                linha = Console.ReadLine();
                i++;
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
                        jogador.ler(linha.Substring(2));
                        time.inserir(jogador);
                        break;
                    case "R":
                        time.remover();
                        break;
                    default:
                        break;
                }
                linha = Console.ReadLine();
            }
            time.mostrar();
        }
    }
}