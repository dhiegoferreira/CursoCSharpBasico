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

        public string _name;
        public WorkerLevel _level; //Need verify
        public double _baseSalary; //Need veirfy
        public Department _nameDepartment = new Department();



        //Creating a list of the Department 
        //Lenght maybe choice.
        public List<HourContract> listContract { get; private set; } = new List<HourContract>();
        
        
        //Constructor method
        public Worker(string name, WorkerLevel level, double baseSalary, string nameDepartment)
        {
            _name = name;
            _level = level;
            _baseSalary = baseSalary;
            _nameDepartment.Name = nameDepartment;
        }


        //Adding contracts 
        public void addContract(HourContract contract)
        {
            listContract.Add(contract);
        }


        public void removeContract(HourContract contract)
        {

        }

        public double Income(int month, int year)
        {
            //Algo assim
            //Precisamos fazer uma busca nos elementos da lista de contratos do trabalhador pela mês/Ano
            double sum = _baseSalary;

            //Percorrendo a lista de contratos do trabalhador
            foreach (HourContract contract in listContract)
            {
                //Vamos pegar o valor da hora (valuePerHour) e multiplicar pela quantidade de horas(hour)
                //Primeiro devemos saber o mês e ano
                if (contract._date.Year == year && contract._date.Month == month)
                {
                    sum += contract.TotalValue(); 
                }

            }

            return sum;
        }






    }
}
