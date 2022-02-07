using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section14.HerancaMultipla.Entities
{

    //Quando tivermos uma classe em UML com o nome em itálico, sabemos que aquela classe é abstrata e, portanto, não poderemos instancia-la
    // notacação: abstract
    abstract class Device
    {
        public int SerialNumber { get; set; }


        public abstract void ProcessDoc(string document);

    }
}
