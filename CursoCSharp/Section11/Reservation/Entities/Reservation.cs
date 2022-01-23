using System;
using CursoCSharp.Section11.Reservation.Entities.Exceptions;

namespace CursoCSharp.Section11.Reservation.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set;} //Format data dd/MM/yyyy
        public DateTime CheckOut { get; set; } //Format data dd/MM/yyyy



        //Métodos construtores
        //Irei trazer o bloco try-catch
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            
            //Lembrar que não podemos utilizar else if
            //pois quando a exceção é lançada, o programa foca a exceção e não executará as demais linhas.
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("CheckOut date must be after CheckIn date.");
            }

            //Fazer com que os atributos da classe recebam os parâmetros de entrada
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;

        }


        public int Duration()
        {
            //int duration = int.Parse(CheckOut.ToString().Substring(0, 1)) - int.Parse(CheckIn.ToString().Substring(0, 1));
            //Aprender a usar o TimeSpan
            TimeSpan duration = CheckOut.Subtract(CheckIn);     
            return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            
            //Remember: Tha date of reservation is always after day.
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainException("CheckOut date must be after CheckIn date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

        }



        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in :"
                + CheckIn.ToString("dd/MM/yyyy")
                + ", ckeck-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";

        }

    }
}
