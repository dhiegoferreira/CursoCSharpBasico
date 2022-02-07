using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section14.HerancaMultipla.Entities
{
    internal class Scanner : Device
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan() 
        {
            return "scanner scan result.";
        }
    }
}
