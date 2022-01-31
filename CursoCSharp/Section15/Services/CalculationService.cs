using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section15.Services
{
    class CalculationService
    {
        //Para achar o maior elemento de uma lista
        //é necessários definirmos tipos que permitem a comparação.
        public int Max(List<int> list)
        {
            if(list.Count == 0)
            {
                //Lista vazia, não conseguiremos encontrar o maior
                throw new ArgumentException("The list can not be empty"); // Caso não haja elementos na lista..
            }
            int max = list[0]; //Começo pegando o valor da posição inicial [0]

            for (int i = 0; i < list.Count; i++) // i poderia começar com 1 para não comparar com max = list[0] (ele mesmo)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }

                //Se o elemento da esquerda for maior que elemento da direita
                //então a variável max receberá este valor. A comparação segue para
                //todos os elementos da lista.
            }

            return max;

        }
    }
}
