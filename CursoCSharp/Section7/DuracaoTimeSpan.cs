using System;


namespace CursoCSharp.Section7
{
    internal class DuracaoTimeSpan
    {
        static void Main(string[] args)
        {
            //TimeSpan: represena uma duração
            //É um tipo valor (struct)
            //Contrutores
            //TimeSpan()
            //TimeSpan(ticks)
            //TimeSpan(horas, minutos, segundos)
            //TimeSpan(dias, horas, segundos)
            //TimeSpan(dias, horas, minutos, segundos, milissegundos)


            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(13, 20, 55);
            TimeSpan t3 = new TimeSpan(1, 13, 20, 55);
            TimeSpan t4 = new TimeSpan(1, 20, 20, 55, 231);

            //TimeSpan.From

            TimeSpan t5 = TimeSpan.FromDays(1.5);
            TimeSpan t6 = TimeSpan.FromHours(4.5);
            TimeSpan t7 = TimeSpan.FromMinutes(3.5);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            
        }
    }
}
