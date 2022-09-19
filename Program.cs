using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_EX3_ConjuntoDeInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            ConjuntoDeInteiros conjunto = new ConjuntoDeInteiros();
            List<int> conjuntoInteiros1 = new List<int>();
            List<int> conjuntoInteiros2 = new List<int>();

            conjuntoInteiros1.Add(1);
            conjuntoInteiros1.Add(5);
            conjuntoInteiros1.Add(7);
            conjuntoInteiros1.Add(8);

            conjuntoInteiros2.Add(1);
            conjuntoInteiros2.Add(5);
            conjuntoInteiros2.Add(7);
            conjuntoInteiros2.Add(8);

            Console.WriteLine(conjunto.ToSetString(conjuntoInteiros1));
            Console.WriteLine(conjunto.ToSetString(conjuntoInteiros2));

            Console.WriteLine("UNIAO");

            foreach (bool item in conjunto.uniao(10, conjuntoInteiros1, conjuntoInteiros2))
            {
                Console.Write(item);
            }
            Console.WriteLine("\nINTERSECCAO");
            foreach (bool item2 in conjunto.intersecao(10, conjuntoInteiros1, conjuntoInteiros2))
            {
                Console.Write(item2);
            }

            Console.WriteLine("\nINSERE ELEMENTO");
            foreach (bool item3 in conjunto.insereElemento(10, 10, conjuntoInteiros1))
            {
                Console.Write(item3);
            }

            Console.WriteLine("\nDELETA ELEMENTO");
            foreach (bool item4 in conjunto.deletaElemento(10, 7, conjuntoInteiros1))
            {
                Console.Write(item4);
            }

            Console.WriteLine("\nOS CONJUNTOS SÃO IGUAIS? " + conjunto.conjuntoIsEqual(conjuntoInteiros1, conjuntoInteiros2));
        }
    }
}
