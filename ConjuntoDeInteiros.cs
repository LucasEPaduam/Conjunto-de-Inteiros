using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_EX3_ConjuntoDeInteiros
{
    class ConjuntoDeInteiros
    {

        private List<bool> conjunto;
        private string conjuntoImpresso;

        public ConjuntoDeInteiros()
        {
            this.conjunto = new List<bool>();
        }

        public List<bool> uniao(int tamanhoDoConjunto, List<int> conjunto1, List<int> conjunto2)
        {
            this.conjunto = tamanhoDaLista(tamanhoDoConjunto);


            for (int i = 0; i < this.conjunto.Count; i++)
            {

                if (conjunto1.Contains(i) || conjunto2.Contains(i))
                {
                    this.conjunto[i] = true;
                }

            }

            return this.conjunto;
        }

        public List<bool> intersecao(int tamanhoDoConjunto, List<int> conjunto1, List<int> conjunto2)
        {
            this.conjunto = tamanhoDaLista(tamanhoDoConjunto);


            for (int i = 0; i < this.conjunto.Count; i++)
            {

                if (conjunto1.Contains(i) && conjunto2.Contains(i))
                {
                    this.conjunto[i] = true;
                }

            }

            return this.conjunto;
        }

        public List<bool> insereElemento(int tamanhoDoConjunto, int elemento, List<int> conjunto)
        {

            this.conjunto = tamanhoDaLista(tamanhoDoConjunto);
            for (int i = 0; i < this.conjunto.Count; i++)
            {

                if (conjunto.Contains(i))
                {
                    this.conjunto[i] = true;
                }

            }

            conjunto.Add(elemento);
            this.conjunto[elemento] = true;

            return this.conjunto;

        }

        public List<bool> deletaElemento(int tamanhoDoConjunto, int elemento, List<int> conjunto)
        {

            this.conjunto = tamanhoDaLista(tamanhoDoConjunto);
            for (int i = 0; i < this.conjunto.Count; i++)
            {

                if (conjunto.Contains(i))
                {
                    this.conjunto[i] = true;
                }

            }

            conjunto.Remove(elemento);
            this.conjunto[elemento] = false;

            return this.conjunto;

        }

        public string ToSetString(List<int> conjuntoExpresso)
        {
            if (conjuntoExpresso.Count != 0)
            {
                foreach (int item in conjuntoExpresso)
                {
                    conjuntoImpresso += item + "-";
                }

                conjuntoImpresso = "CONJUNTO {" + conjuntoImpresso + "}";

                return conjuntoImpresso;
            }
            else
            {
                return "CONJUNTO { - }";
            }
        }

        public Boolean conjuntoIsEqual(List<int> conjunto1, List<int> conjunto2)
        {

            if (conjunto1.Count != conjunto2.Count)
            {
                for (int i = 0; i < conjunto1.Count; i++)
                {
                    if (conjunto1[i] != conjunto2[i])
                    {
                        return false;
                    }

                    
                }

                return false;
            }
            return true;
        }


        private List<bool> tamanhoDaLista(int tamanho)
        {
            this.conjunto.Clear();
            for (int i = 0; i <= tamanho; i++)
            {
                this.conjunto.Add(false);
            }

            return this.conjunto;

        }
    }
}








