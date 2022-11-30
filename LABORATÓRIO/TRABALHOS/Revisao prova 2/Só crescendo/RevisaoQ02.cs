using System;

namespace TP01
{
    class RevisaoQ02
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

        public static String ordemCrescente(int[] array)
        {
            String resp = "NAO";
            if (array.Length == 1)
            {
                resp = "SIM";
            }
            else
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[i - 1])
                    {
                        resp = "SIM";
                    }
                    else
                    {
                        resp = "NAO";
                        i = array.Length;
                    }
                }
            }
            return resp;
        }

        static void Main(string[] args)
        {
            String quantidade = Console.ReadLine();
            int[] array = new int[0];
            String arrayTamanho = "";

            for (int i = 0; i < int.Parse(quantidade); i++)
            {
                arrayTamanho = Console.ReadLine();
                array = new int[int.Parse(arrayTamanho)];
                array = Array.ConvertAll<String, int>(Console.ReadLine().Split(), int.Parse);
                Sort(array);
                Console.WriteLine(ordemCrescente(array));
            }

        }
    }
}

