using System;

namespace TP03Q03
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

        public static Jogadores[] SortArray(Jogadores[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);

                MergeArray(array, left, middle, right);
            }

            return array;
        }
        public static void MergeArray(Jogadores[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new Jogadores[leftArrayLength];
            var rightTempArray = new Jogadores[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i].nascimento <= rightTempArray[j].nascimento)
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
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
            SortArray(jogador, 0, i-1);
            for (int j = 0; j < i; j++)
            {
                jogador[j].imprimir();
            }
        }
    }
}

