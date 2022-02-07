using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section14.HerancaMultiplaCorrecao.Entities
{
    interface IScanner
    {
        string Scan(); //Não precisamos do especificador de acesso public pois na interface os métodos são públicos por padrão.
    }
}
