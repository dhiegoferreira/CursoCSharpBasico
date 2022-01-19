using System.Collections.Generic;
using System;

namespace CursoCSharp.Section9
{
    class Worker
    {
        //Atributos privativos
        //Propriedade autoimplementadas 
        //Construtores  
        //Propriedade customizadas
        //Outris métodos da classe.

        public string Name;
        public WorkerLevel Level; //Need verify
        public double BaseSalary; //Need veirfy
        public Department NameDepartment = new Department();



        //Creating a list of the Department 
        //Lenght maybe choice.
        public List<HourContract> listContract { get; private set; } = new List<HourContract>();
        
        //Constructor void (parâmetros não necessários)
        public Worker()
        {

        }



        //Constructor method with parameters
        public Worker(string name, WorkerLevel level, double baseSalary, string nameDepartment)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            NameDepartment.Name = nameDepartment;
        }


        //Adding contracts 
        public void addContract(HourContract contract)
        {
            listContract.Add(contract);
        }


        public void removeContract(HourContract contract)
        {
            listContract.Remove(contract);
        }

        public double Income(int month, int year)
        {
            //Algo assim
            //Precisamos fazer uma busca nos elementos da lista de contratos do trabalhador pela mês/Ano
            double sum = BaseSalary;

            //Percorrendo a lista de contratos do trabalhador
            foreach (HourContract contract in listContract)
            {
                //Vamos pegar o valor da hora (valuePerHour) e multiplicar pela quantidade de horas(hour)
                //Primeiro devemos saber o mês e ano
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); 
                }
            }
            return sum;
        }

    }
}
