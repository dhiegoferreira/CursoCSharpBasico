using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section6
{
    class DesacolacaoPorGarbageCollector
    {
       static void Main(string[] args)
        {
            Produtos p1, p2;

            p1 = new Produtos("TV", 900.00, 0);


            p2 = new Produtos("Mouse", 30.00, 0);

            //O ponteiro de p1 apontado para o objeto criado em Heap como referência será desalocado e passará a apontar para o objeto de referência em p2;

            p1 = p2;

            

        }

       
    }
}
