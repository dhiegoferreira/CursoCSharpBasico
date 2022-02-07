using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section14.HerancaMultiplaCorrecao.Entities
{
    abstract class Device
    {

        public string SerialNumber { get; set; }



        //assinatura do método abstrato
        public abstract void PocessDoc(string document);

        //As subclasses devem, necessariamente, sobreescrever estes métodos.
    }
}
