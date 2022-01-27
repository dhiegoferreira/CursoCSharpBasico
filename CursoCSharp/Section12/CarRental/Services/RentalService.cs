using System;
using System.Globalization;
using Section12.Entities;


namespace Section12.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; } //Só posso obtêlos de outra classe, não posso modificar
        public double PricePerDay { get; private set; }

        //Declaração da depencência entre serviços (BrazilTaxService DEPENDE de RentalService)
        //Agora vamos fazer a inversão de controle por meior de injeção de dependência

        //private BrazilTaxService _brazilTaxService = new BrazilTaxService();  
        private ITaxService _taxService;
        

        //Método Construtor 
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }


        //Método para calcular o valor da fatura com base no tempo de locação
        //Veja que o método defini como 
        public void ProcessInvoice(CarRental carRental)
        {

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
           

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            } else
            {

                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);

            }

            double tax  = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
            
        }
    }
}
