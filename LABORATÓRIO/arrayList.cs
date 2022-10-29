using System;
using System.Collections;

namespace TP01
{
    class Q01 {        

        public static void imprimeArrayList(ArrayList arrayList){
            foreach (var item in arrayList)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Paulo");
            al.Add("Eduardo");
            al.Add("Miranda");
            imprimeArrayList(al);
            al.Reverse();
            imprimeArrayList(al);
            al.Sort();
            imprimeArrayList(al);
        }
    }
}