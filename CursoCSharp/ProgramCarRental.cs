using System;
using Section12.Entities;
using System.Globalization;
using Section12.Services;


namespace Section12
{
    class ProgramCarRental
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model:");
            string carModel = Console.ReadLine();

            //Data e horário de início da locação
            Console.Write("Pickup (dd/MM/yyyy HH:mm):");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            //Data e horário do fim da locação
            Console.Write("Return (dd/MM/yyyy HH:mm):");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            //PerseExact(string s, format, IFormatProvider Provider)
            Console.Write("Enter price per hour:");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day:");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //Criando o objeto do tipo Aluguel de Carro e passando datas de inicio e fim do aluguel, bem como passando um objeto do tipo Vehicle para o 3° parâmetro
            CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));


            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new EuaTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
