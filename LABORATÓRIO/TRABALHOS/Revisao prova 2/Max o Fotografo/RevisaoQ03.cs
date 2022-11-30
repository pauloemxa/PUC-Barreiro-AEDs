using System;

namespace TP01
{
    class RevisaoQ03
    {
        static void Swap(int[] array, int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
        public static void Sort(int[] array)
        {
            SortQuicksort(0, array.Length - 1, array);
        }
        private static void SortQuicksort(int esq, int dir, int[] array)
        {
            int i = esq, j = dir;
            int pivo = array[(dir + esq) / 2];
            while (i <= j)
            {
                while (array[i] < pivo) i++;
                while (array[j] > pivo) j--;
                if (i <= j)
                {
                    Swap(array, i, j);
                    i++;
                    j--;
                }
            }
            if (esq < j) SortQuicksort(esq, j, array);
            if (i < dir) SortQuicksort(i, dir, array);
        }

        public static String podeFoto(int[] array, int distanciaFileira){
            String resp = "NAO";
            for (int i = 0, j = array.Length/2; i < array.Length/2; i++, j++)
            {
                if (array[i]+distanciaFileira <= array[j])
                {
                    resp = "SIM";
                }else{
                    resp = "NAO";
                    i = array.Length;
                }
            }
            return resp;
        }

        static void Main(string[] args)
        {
            String quantidade = Console.ReadLine();
            int[] array = new int[0];
            int arrayTamanho = 0, distanciaFileiraInt = 0;
            String[] comandos = {""};

            for (int i = 0; i < int.Parse(quantidade); i++)
            {
                comandos = Console.ReadLine().Split(' ');
                arrayTamanho = 2*int.Parse(comandos[0]);
                distanciaFileiraInt = int.Parse(comandos[1]);
                array = new int[arrayTamanho];
                array = Array.ConvertAll<String, int>(Console.ReadLine().Split(' '), int.Parse);
                Sort(array);
                Console.WriteLine(podeFoto(array, distanciaFileiraInt));
            }

        }
    }
}

