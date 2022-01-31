using CursoCSharp.Section10.Aula127.Entities;
using System;


//Programa sobre Herança e polimorfismo
//Iremos criar uma classe conta (Account) que será a Super Classe
//Teremos duas classe especializadas BusinessAccount and SavingAccount
namespace CursoCSharp
{
    class ProgramBankAccounts
    {
        static void Main()
        {

            Account acc1 = new Account(1001, "Alice", 500.0);

            Account acc2 = new SavingAccount(1002, "Carlos", 500.0, 0.01);

            SavingAccount sacc1 = new SavingAccount(1003, "Jonas", 600.0, 0.01);


            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);
            sacc1.WithDraw(10.00);

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("acc1 Account = Account  :" + acc1.GetType());
            Console.WriteLine("acc2 Account = SavinAccount  : " + acc2.GetType());
            Console.WriteLine("sacc1 SavingAccount = SavinAcount  :" + sacc1.GetType());

            Console.WriteLine("---------------------------------------------------");



            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(sacc1.Balance);
        }
    }
}
