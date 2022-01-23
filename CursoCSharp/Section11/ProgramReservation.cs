using System;
using CursoCSharp.Section11.Reservation.Entities.Exceptions;
using CursoCSharp.Section11.Reservation.Entities;


namespace CursoCSharp
{
    class ProgramReservation

    {

        static void Main()
        {
            try
            {
                //Chamamos o conteúdo da tentativa de SCNEARIO
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Checkout data (dd/MM/yyyy:");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);


                Console.WriteLine("");
                Console.WriteLine(reservation);

                //Para atualizar
                Console.WriteLine("Enter data to update the reservation :");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Checkout data (dd/MM/yyyy:");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("");
                Console.WriteLine(reservation);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error message: " + e.Message);
                //.Message obtém a messagem de erro tratada, 
            } 
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }






        }
    }
}
