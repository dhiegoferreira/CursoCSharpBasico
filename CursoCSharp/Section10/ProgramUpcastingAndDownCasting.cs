using CursoCSharp.Section10.Aula127.Entities;


//Programa para iniciar a Section10 com o tópico: UPCASTIN E DOWNCASTING (AULA 127)
namespace CursoCSharp
{
    class ProgramUpcastingAndDownCasting
    {
        static void Main()
        {
            BusinessAccount  bacc1 = new BusinessAccount(1001, "João", 100.00, 1500.00);
            SavingAccount sacc2 = new SavingAccount(1001, "Lucas", 500.00, 0.1);
            Account acc1 = new Account(1002, "Maria", 900.00);


            //UPCASTING
            //(casting implícito da subclasse para a superclasse): Nesse caso, não é necessário forçar a conversão
            Account acc2 = bacc1;
            Account acc3 = new BusinessAccount(1003, "Larissa", 450.00, 2500.00);
            Account acc4 = new SavingAccount(1004, "Paulo", 250.00, 0.01);


            //DOWNCASTING
            ////(Conversão da superclasse para a subclasse.)

            BusinessAccount acc5 = (BusinessAccount) acc3;
            //BusinessAccount acc5 = acc3 as BusinessAccount; OUTRA FORMA DE APLICAR O (CASTING)

            //Apesar de o conteúdo da variável acc3 ser BusinessAaccount o compilador ainda não conhece o tipo de dado do conteúdo, ele leva em consideração o tipo declarado.
            //Account acc3 = new BusinessAcount();
            
        }
    }
}
