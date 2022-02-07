using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section14.HerancaMultipla.Entities
{
    internal class Printer : Device
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }


        public void Print(string document)
        {
            Console.WriteLine("Printer print: "  + document);

        }

    }
}
