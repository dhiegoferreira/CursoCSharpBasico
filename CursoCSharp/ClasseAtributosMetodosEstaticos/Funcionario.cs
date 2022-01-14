using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.OOPInicio
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        //Dois métodos SalarioLiquido e Aumentar Salario

        public double SalarioLiquido()
        {
            SalarioBruto -= Imposto;
            return SalarioBruto;
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem = porcentagem / 100;
            SalarioBruto = SalarioBruto + (SalarioBruto*porcentagem);

            Console.WriteLine("Dados Atualizados: " + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));
        }

        //Formatando a string
        public override string ToString()
        {
            return "Funcionario: " + Nome
                + ", " + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
