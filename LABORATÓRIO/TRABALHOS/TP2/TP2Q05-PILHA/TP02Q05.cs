using System;

namespace TP02Q05
{
    class PilhaJogadores
    {
        private Jogadores[] array;
        private int n;
        /**
         * Construtor da classe.
         */

        /**
         * Construtor da classe.
         * @param tamanho Tamanho da lista.
         */
        public PilhaJogadores(int tamanho)
        {
            array = new Jogadores[tamanho];
            n = 0;
        }


        /**
         * Insere um elemento na ultima posicao da lista.
         * @param x int elemento a ser inserido.
         * @throws Exception Se a lista estiver cheia.
         */
        public void inserirFim(Jogadores x)
        {

            //validar insercao
            if (n >= array.Length)
            {
                throw new Exception("Erro ao inserir!");
            }

            array[n] = x;
            n++;
        }


        /**
         * Remove um elemento da ultima posicao da lista.
         * @return resp int elemento a ser removido.
         * @throws Exception Se a lista estiver vazia.
         */
        public Jogadores removerFim()
        {

            //validar remocao
            if (n == 0)
            {
                throw new Exception("Erro ao remover!");
            }

            return array[--n];
        }


        /**
         * Mostra os elementos da lista separados por espacos.
         */
        public void mostrar()
        {
            for (int i = 0; i < n; i++)
            {
                array[i].imprimir();
            }
        }

        /**
         * Procura um elemento e retorna se ele existe.
         * @param x int elemento a ser pesquisado.
         * @return <code>true</code> se o array existir,
         * <code>false</code> em caso contrario.
         */
        public bool pesquisar(Jogadores x)
        {
            bool retorno = false;
            for (int i = 0; i < n && retorno == false; i++)
            {
                retorno = (array[i] == x);
            }
            return retorno;
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

            PilhaJogadores time = new PilhaJogadores(20);
            Jogadores jogador = new Jogadores();

            int i = 0, tamComandos = 0;

            while (linha != "FIM")
            {
                jogador = new Jogadores();
                jogador.ler(linha);
                time.inserirFim(jogador);
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
                        time.inserirFim(jogador);
                        break;
                    case "R":
                        time.removerFim();
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