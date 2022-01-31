

//Iremos tirar dúvidas com relação aos modificadores/especificadores de acesso
//Lembrar que temos Tipos e membros de tipos
//Membros de tipos são: variáveis, propriedades e construtores
//Tipos: Classes, Structs, Enums, Interfaces e Delegates
namespace CursoCSharp.DotNetTutorials.AcessSpecifiers

{
    public class Customer
    {
        //Region private fields
        private int _id;


        //End region


        //Region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }

    public class MainClass
    {
        private static void Main()
        {
            Customer customer = new Customer();
            
            
            //customer._id = 12;
            //Não posso acessar diretamente o campo _id pois há um especificador de aceso
            //do tipo privado.

            System.Console.WriteLine(customer.Id);
        }

    }
}
