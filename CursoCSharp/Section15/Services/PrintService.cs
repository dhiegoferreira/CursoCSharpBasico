using System;
using System.Collections.Generic;
using System.Linq;


namespace CursoCSharp.Section15.Services
{
    class PrintService
    {

        
      
        public void AddValue(List<int> listNumbers, int num)
        {
            listNumbers.Add(num);
        }


        //Este método pegará a lista e retornará o primeiro elemento dela
        public int First(List<int> listNumbers)
        {
            //lista.First utiliza o Linq
            return listNumbers.First<int>();
        }

        //
        public void Print(List<int> listNumbers)
        {
            foreach(int inteiros in listNumbers)
            {
                Console.Write(inteiros + ", ");

            }
        }
    }
}
