using System;

namespace TP02Q03
{
    class ListaJogadores
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
        public ListaJogadores(int tamanho)
        {
            array = new Jogadores[tamanho];
            n = 0;
        }


        /**
         * Insere um elemento na primeira posicao da lista e move os demais
         * elementos para o fim da lista.
         * @param x int elemento a ser inserido.
         * @throws Exception Se a lista estiver cheia.
         */
        public void inserirInicio(Jogadores x)
        {
            //validar insercao
            if (n >= array.Length)
            {
                throw new Exception("Erro ao inserir!");
            }

            //levar elementos para o fim do array
            for (int i = n; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = x;
            n++;
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
         * Insere um elemento em uma posicao especifica e move os demais
         * elementos para o fim da lista.
         * @param x int elemento a ser inserido.
         * @param pos Posicao de insercao.
         * @throws Exception Se a lista estiver cheia ou a posicao invalida.
         */
        public void inserir(Jogadores x, int pos)
        {
            //validar insercao
            if (n >= array.Length || pos < 0 || pos > n)
            {
                throw new Exception("Erro ao inserir!");
            }

            //levar elementos para o fim do array
            for (int i = n; i > pos; i--)
            {
                array[i] = array[i - 1];
            }

            array[pos] = x;
            n++;
        }


        /**
         * Remove um elemento da primeira posicao da lista e movimenta 
         * os demais elementos para o inicio da mesma.
         * @return resp int elemento a ser removido.
         * @throws Exception Se a lista estiver vazia.
         */
        public Jogadores removerInicio()
        {

            //validar remocao
            if (n == 0)
            {
                throw new Exception("Erro ao remover!");
            }

            Jogadores resp = array[0];
            n--;

            for (int i = 0; i < n; i++)
            {
                array[i] = array[i + 1];
            }

            return resp;
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
         * Remove um elemento de uma posicao especifica da lista e 
         * movimenta os demais elementos para o inicio da mesma.
         * @param pos Posicao de remocao.
         * @return resp int elemento a ser removido.
         * @throws Exception Se a lista estiver vazia ou a posicao for invalida.
         */
        public Jogadores remover(int pos)
        {

            //validar remocao
            if (n == 0 || pos < 0 || pos >= n)
            {
                throw new Exception("Erro ao remover!");
            }

            Jogadores resp = array[pos];
            n--;

            for (int i = pos; i < n; i++)
            {
                array[i] = array[i + 1];
            }

            return resp;
        }


        /**
         * Mostra os elementos da lista separados por espacos.
         */
        public void mostrar()
        {
            Console.Write("[ ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
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
            for (int j = 0; j < int.Parse(linha); j++)
            {
                // Console.WriteLine();
                // linha = Console.ReadLine();
            }
        }
    }
}