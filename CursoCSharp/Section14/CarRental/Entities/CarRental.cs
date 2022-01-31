using System;
using System.Collections.Generic;
using System.Text;

namespace Section13.CarRental.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null; //Não precisava, pois por default já vem null pois não passamos parâmetros.
        }
    }
}
