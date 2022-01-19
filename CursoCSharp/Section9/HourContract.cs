using System;
using System.Globalization;


namespace CursoCSharp.Section9
{
    class HourContract
    {
        public DateTime _date { get; set; }
        public double _valuePerHour { get; set; }
        public int _hours { get; set; }




        public HourContract()
        {


        }


        //Método Construtor
        public HourContract(DateTime data, double valuePerHour, int hour)
        {

            _date = data;
            _valuePerHour = valuePerHour;
            _hours = hour;

        }


        public double TotalValue()
        {

            return _valuePerHour * _hours;
        }
        


    }
}
