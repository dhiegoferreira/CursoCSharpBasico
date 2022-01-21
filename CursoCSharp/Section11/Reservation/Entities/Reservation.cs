using System;

namespace CursoCSharp.Section11.Reservation.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set;} //Format data dd/MM/yyyy
        public DateTime Checkout { get; set; } //Format data dd/MM/yyyy


        //Métodos construtores

        //Irei trazer o bloco try-catch
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
           

        }


        public int Duration()
        {

            int duration = int.Parse(Checkout.ToString().Substring(0, 1)) - int.Parse(Checkin.ToString().Substring(0, 1));

            return duration;
        }

        public void UpdateDates(DateTime checking, DateTime checkout)
        {
            Checkin = checking;
            Checkout = checkout;
        }


    }
}
