using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.OOPInicio
{
    class Retangulo
    {
        public double width;
        public double hight;

        public double Area()
        {
            return (width * hight);
        }

        public double Perimetro()
        {
            return ((2 * width) + (2 * hight));
        }
    
        public double Diagonal()
        {
            return (Math.Sqrt((width * width) + (hight * hight)));
        }

        //Formatação para string
        //Pooso concatnerar com métodos ou atributos
        public override string ToString()
        {
            return " Area: " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\n Perímetro: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\n Diagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
                
        }

    }
}
