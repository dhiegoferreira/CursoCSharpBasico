using System;
using System.Globalization;


namespace CursoCSharp.Section9
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public HourContract()
        {


        }


        //Método Construtor
        public HourContract(DateTime data, double valuePerHour, int hour)
        {

            Date = data;
            ValuePerHour = valuePerHour;
            Hours = hour;

        }


        public double TotalValue()
        {

            return ValuePerHour * Hours;
        }
        


    }
}
