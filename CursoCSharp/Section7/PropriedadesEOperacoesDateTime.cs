using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Section7
{
    internal class PropriedadesEOperacoesDateTime
    {
        //Propriedades e operações com DateTime

        static void Main(string[] args)
        {


            DateTime data = new DateTime(2022, 2, 5, 15, 45, 58, 222);


            //PROPRIEDADES

            //Date (DateTime)
            //Day (int)
            //DayOfWeek (DayOfWeek)
            //DayOfYear (int)
            //Hour (int)
            //Kind (DateTimeKind)
            //Millisencond (int)
            //Minute (int)
            //Month (int)
            //Second (int)
            //Ticks (long)
            //TimeOfDay (TimeSpan)
            //Yead (int)
            Console.WriteLine("--------------Propriedades-------------------");
            Console.WriteLine("1) Data: "+ data.Date);//Desconsidera o horário informado, ou seja, retorna meia noite da data informada.

            Console.WriteLine("2) Day: " + data.Day);
            Console.WriteLine("3) DayOfWeek: "+ data.DayOfWeek);
            Console.WriteLine("4) DayOfYear: "+ data.DayOfYear); //dia do ano
            Console.WriteLine("5) Hour: "+ data.Hour); //Retorna apenas a hora (sem minutos)
            Console.WriteLine("6) Kind: " + data.Kind); //se é local ou global
            Console.WriteLine("7) Millisecond: " +data.Millisecond);
            Console.WriteLine("8) Minute: " + data.Minute);
            Console.WriteLine("9) Second: " + data.Second);
            Console.WriteLine("10) Ticks: " + data.Ticks);
            Console.WriteLine("11) TimeOfDay: " + data.TimeOfDay);
            Console.WriteLine("12) Yead: " + data.Year);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------Funções ou Métodos------------------------");
            Console.WriteLine();
            Console.WriteLine();
          
            
            //Funções ou métodos
            Console.WriteLine(data.ToLongDateString()); //Data por extenso
            Console.WriteLine(data.ToLongTimeString()); //Relogio em PM
            Console.WriteLine(data.ToShortDateString()); //Data exatamente igual a do computador
            Console.WriteLine(data.ToShortTimeString()); //Hora e minutos com PM
            Console.WriteLine(data.ToString());
            Console.WriteLine(data.ToString("yyyy-MM-dd HH:mm:ss"));


            //Operações com DateTime

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------OPERAÇÕES COM DateTime-----------------------------");
            Console.WriteLine();
            Console.WriteLine();
            TimeSpan timeSpan = new TimeSpan(200);
            
            Console.WriteLine(data.Add(timeSpan)); //Adiciona tiques
            Console.WriteLine(data.AddDays(2)); //Adiciona dias
            Console.WriteLine(data.AddHours(3)); //Adiciona horas
            Console.WriteLine(data.AddMilliseconds(2));
            Console.WriteLine(data.AddMinutes(2));
            Console.WriteLine(data.AddMonths(2));
            Console.WriteLine(data.AddSeconds(2));
            Console.WriteLine(data.AddTicks(2));
            Console.WriteLine(data.AddYears(2));




        }

    }
}
