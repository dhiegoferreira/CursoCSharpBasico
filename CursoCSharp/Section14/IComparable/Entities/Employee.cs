using System.Globalization;

namespace CursoCSharp.Section14.IComparable.Entities
{
    //Esta classe será responsável por definir um empregado.
    //Este empregador será do tipo csv e nós iremos recebe-lô por parâmetro do construtor
    //Definiremos um nome e um salário.

    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }


        public Employee(string csvEmployee)
        {
            //Método split divide um cadeia de caracteres em subcadeias de  caracteres.
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];//Pois os texto estão:
            //[Nome, Salário]
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);


        }

        public override string ToString()
        {
            return $"Name: {Name} \n" 
                +"Salary: " + Salary;
        }

    }
}
